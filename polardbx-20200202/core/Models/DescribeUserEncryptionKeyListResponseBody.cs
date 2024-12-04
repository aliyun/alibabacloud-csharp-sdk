// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeUserEncryptionKeyListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUserEncryptionKeyListResponseBodyData Data { get; set; }
        public class DescribeUserEncryptionKeyListResponseBodyData : TeaModel {
            [NameInMap("KeyIds")]
            [Validation(Required=false)]
            public List<string> KeyIds { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FEA5DC20-6D8A-5979-97AA-FC57546ADC20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
