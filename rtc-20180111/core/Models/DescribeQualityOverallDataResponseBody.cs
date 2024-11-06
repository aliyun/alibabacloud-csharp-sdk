// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeQualityOverallDataResponseBody : TeaModel {
        [NameInMap("QualityOverallData")]
        [Validation(Required=false)]
        public List<DescribeQualityOverallDataResponseBodyQualityOverallData> QualityOverallData { get; set; }
        public class DescribeQualityOverallDataResponseBodyQualityOverallData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.9376</para>
            /// </summary>
            [NameInMap("Average")]
            [Validation(Required=false)]
            public string Average { get; set; }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeQualityOverallDataResponseBodyQualityOverallDataNodes> Nodes { get; set; }
            public class DescribeQualityOverallDataResponseBodyQualityOverallDataNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1615831200</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0000</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>JOIN_CHANNEL_SUC_RATE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
