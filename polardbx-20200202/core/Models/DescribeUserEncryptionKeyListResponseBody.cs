// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeUserEncryptionKeyListResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUserEncryptionKeyListResponseBodyData Data { get; set; }
        public class DescribeUserEncryptionKeyListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The key list.</para>
            /// </summary>
            [NameInMap("KeyIds")]
            [Validation(Required=false)]
            public List<string> KeyIds { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEA5DC20-6D8A-5979-97AA-FC57546ADC20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
