// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostShareKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the shared keys.</para>
        /// </summary>
        [NameInMap("HostShareKeys")]
        [Validation(Required=false)]
        public List<ListHostShareKeysResponseBodyHostShareKeys> HostShareKeys { get; set; }
        public class ListHostShareKeysResponseBodyHostShareKeys : TeaModel {
            /// <summary>
            /// <para>The number of the associated host accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostAccountCount")]
            [Validation(Required=false)]
            public long? HostAccountCount { get; set; }

            /// <summary>
            /// <para>The shared key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10247</para>
            /// </summary>
            [NameInMap("HostShareKeyId")]
            [Validation(Required=false)]
            public string HostShareKeyId { get; set; }

            /// <summary>
            /// <para>The name of the shared key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("HostShareKeyName")]
            [Validation(Required=false)]
            public string HostShareKeyName { get; set; }

            /// <summary>
            /// <para>The time when the shared key was last modified. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1644806406</para>
            /// </summary>
            [NameInMap("LastModifyKeyAt")]
            [Validation(Required=false)]
            public long? LastModifyKeyAt { get; set; }

            /// <summary>
            /// <para>The fingerprint of the private key.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("PrivateKeyFingerPrint")]
            [Validation(Required=false)]
            public string PrivateKeyFingerPrint { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of the shared keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
