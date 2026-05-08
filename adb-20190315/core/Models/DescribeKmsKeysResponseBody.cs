// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeKmsKeysResponseBody : TeaModel {
        [NameInMap("KmsKeys")]
        [Validation(Required=false)]
        public DescribeKmsKeysResponseBodyKmsKeys KmsKeys { get; set; }
        public class DescribeKmsKeysResponseBodyKmsKeys : TeaModel {
            [NameInMap("KmsKey")]
            [Validation(Required=false)]
            public List<DescribeKmsKeysResponseBodyKmsKeysKmsKey> KmsKey { get; set; }
            public class DescribeKmsKeysResponseBodyKmsKeysKmsKey : TeaModel {
                [NameInMap("KeyAlias")]
                [Validation(Required=false)]
                public string KeyAlias { get; set; }

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
