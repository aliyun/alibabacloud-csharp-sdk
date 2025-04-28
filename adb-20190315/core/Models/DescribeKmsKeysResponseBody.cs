// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeKmsKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried KMS keys.</para>
        /// </summary>
        [NameInMap("KmsKeys")]
        [Validation(Required=false)]
        public DescribeKmsKeysResponseBodyKmsKeys KmsKeys { get; set; }
        public class DescribeKmsKeysResponseBodyKmsKeys : TeaModel {
            [NameInMap("KmsKey")]
            [Validation(Required=false)]
            public List<DescribeKmsKeysResponseBodyKmsKeysKmsKey> KmsKey { get; set; }
            public class DescribeKmsKeysResponseBodyKmsKeysKmsKey : TeaModel {
                /// <summary>
                /// <para>The alias of the key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mykey</para>
                /// </summary>
                [NameInMap("KeyAlias")]
                [Validation(Required=false)]
                public string KeyAlias { get; set; }

                /// <summary>
                /// <para>The ID of the key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2e81355b-f8e7-4090-8082-a8f8124a621c</para>
                /// </summary>
                [NameInMap("KeyId")]
                [Validation(Required=false)]
                public string KeyId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F91F25F-8BCF-59E3-AF67-3806DB41FD09</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
