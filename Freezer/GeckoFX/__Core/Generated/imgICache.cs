// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file imgICache.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// imgICache interface
    ///
    /// @author Stuart Parmenter <pavlov@netscape.com>
    /// @version 0.1
    /// @see imagelib2
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bfdf23ff-378e-402e-8a6c-840f0c82b6c3")]
	internal interface imgICache
	{
		
		/// <summary>
        /// Evict images from the cache.
        ///
        /// @param chrome If TRUE,  evict only chrome images.
        /// If FALSE, evict everything except chrome images.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearCache([MarshalAs(UnmanagedType.U1)] bool chrome);
		
		/// <summary>
        /// Find Properties
        /// Used to get properties such as 'type' and 'content-disposition'
        /// 'type' is a nsISupportsCString containing the images' mime type such as
        /// 'image/png'
        /// 'content-disposition' will be a nsISupportsCString containing the header
        /// If you call this before any data has been loaded from a URI, it will
        /// succeed, but come back empty.
        ///
        /// Hopefully this will be removed with bug 805119
        ///
        /// @param uri The URI to look up.
        /// @param doc Optional pointer to the document that the cache entry belongs to.
        /// @returns NULL if the URL was not found in the cache
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIProperties FindEntryProperties([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsIDOMDocument doc);
		
		/// <summary>
        /// Make this cache instance respect private browsing notifications. This
        /// entails clearing the chrome and content caches whenever the
        /// last-pb-context-exited notification is observed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RespectPrivacyNotifications();
		
		/// <summary>
        /// Clear the image cache for a document.  Controlled documents are responsible
        /// for doing this manually when they get destroyed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearCacheForControlledDocument(System.IntPtr doc);
	}
}