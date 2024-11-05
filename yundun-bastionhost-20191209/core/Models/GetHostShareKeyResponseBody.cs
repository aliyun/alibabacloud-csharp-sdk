// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetHostShareKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned information about the shared key.</para>
        /// </summary>
        [NameInMap("HostShareKey")]
        [Validation(Required=false)]
        public GetHostShareKeyResponseBodyHostShareKey HostShareKey { get; set; }
        public class GetHostShareKeyResponseBodyHostShareKey : TeaModel {
            /// <summary>
            /// <para>The ID of the shared key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10427</para>
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
            /// <para>The time when the information about the shared key was last modified. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1644287246</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
