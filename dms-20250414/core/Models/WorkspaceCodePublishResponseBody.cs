// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class WorkspaceCodePublishResponseBody : TeaModel {
        /// <summary>
        /// <para>An object that contains the key for the asynchronous code deployment.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public WorkspaceCodePublishResponseBodyData Data { get; set; }
        public class WorkspaceCodePublishResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The key for the asynchronous code deployment. Use this key to query its status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-xxxx-xxxxxx</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails. This parameter is empty on success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed to deploy，repo branch empty</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates if the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
