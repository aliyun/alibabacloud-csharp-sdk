// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListUserPublicKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the public keys of the user.</para>
        /// </summary>
        [NameInMap("PublicKeys")]
        [Validation(Required=false)]
        public List<ListUserPublicKeysResponseBodyPublicKeys> PublicKeys { get; set; }
        public class ListUserPublicKeysResponseBodyPublicKeys : TeaModel {
            /// <summary>
            /// <para>The description of the public key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The fingerprint of the public key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d8:7d:b6:27:70:2d:07:fb:c6:b6:66:0a:86:7b:0f:9a</para>
            /// </summary>
            [NameInMap("FingerPrint")]
            [Validation(Required=false)]
            public string FingerPrint { get; set; }

            /// <summary>
            /// <para>The ID of the public key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PublicKeyId")]
            [Validation(Required=false)]
            public string PublicKeyId { get; set; }

            /// <summary>
            /// <para>The name of the public key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Keyname</para>
            /// </summary>
            [NameInMap("PublicKeyName")]
            [Validation(Required=false)]
            public string PublicKeyName { get; set; }

            /// <summary>
            /// <para>The ID of the user to which the public key belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

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
        /// <para>The total number of public keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
