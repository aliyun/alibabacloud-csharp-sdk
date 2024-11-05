// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeKmsKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The KMS keys.</para>
        /// </summary>
        [NameInMap("KmsKeys")]
        [Validation(Required=false)]
        public List<DescribeKmsKeysResponseBodyKmsKeys> KmsKeys { get; set; }
        public class DescribeKmsKeysResponseBodyKmsKeys : TeaModel {
            /// <summary>
            /// <para>The alias of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-shh656820f4mh9qxxxxx     alias/test1</para>
            /// </summary>
            [NameInMap("KeyAlias")]
            [Validation(Required=false)]
            public string KeyAlias { get; set; }

            /// <summary>
            /// <para>The key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37291352-xxxx-xxxx-adbf-fd0630a95583</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60EEBD77-227C-5B39-86EA-D89163C5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
