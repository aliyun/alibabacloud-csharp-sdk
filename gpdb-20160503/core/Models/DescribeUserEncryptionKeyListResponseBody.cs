// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeUserEncryptionKeyListResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the KMS keys.</para>
        /// </summary>
        [NameInMap("KmsKeys")]
        [Validation(Required=false)]
        public List<DescribeUserEncryptionKeyListResponseBodyKmsKeys> KmsKeys { get; set; }
        public class DescribeUserEncryptionKeyListResponseBodyKmsKeys : TeaModel {
            /// <summary>
            /// <para>The ID of the KMS key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0b8b1825-fd99-418f-875e-e4dec1dd8715</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
