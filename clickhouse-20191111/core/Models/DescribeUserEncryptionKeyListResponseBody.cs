// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeUserEncryptionKeyListResponseBody : TeaModel {
        [NameInMap("KmsKeys")]
        [Validation(Required=false)]
        public List<DescribeUserEncryptionKeyListResponseBodyKmsKeys> KmsKeys { get; set; }
        public class DescribeUserEncryptionKeyListResponseBodyKmsKeys : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0275bd3f-fdbb-4d8c-846b-71b211******</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D0CEC6AC-7760-409A-A0D5-E6CD8660E9CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
