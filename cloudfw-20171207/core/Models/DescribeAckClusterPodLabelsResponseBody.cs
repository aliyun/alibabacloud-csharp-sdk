// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAckClusterPodLabelsResponseBody : TeaModel {
        [NameInMap("AckLabels")]
        [Validation(Required=false)]
        public List<DescribeAckClusterPodLabelsResponseBodyAckLabels> AckLabels { get; set; }
        public class DescribeAckClusterPodLabelsResponseBodyAckLabels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>storage-operator</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6169C0A4-B91A-5D48-AE4D-B9432D15****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
