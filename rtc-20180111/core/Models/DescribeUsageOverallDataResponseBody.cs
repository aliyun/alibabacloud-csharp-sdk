// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeUsageOverallDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The usage overview data list.</para>
        /// </summary>
        [NameInMap("UsageOverallData")]
        [Validation(Required=false)]
        public List<DescribeUsageOverallDataResponseBodyUsageOverallData> UsageOverallData { get; set; }
        public class DescribeUsageOverallDataResponseBodyUsageOverallData : TeaModel {
            /// <summary>
            /// <para>The list of coordinate points for the metric trends chart.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeUsageOverallDataResponseBodyUsageOverallDataNodes> Nodes { get; set; }
            public class DescribeUsageOverallDataResponseBodyUsageOverallDataNodes : TeaModel {
                /// <summary>
                /// <para>The x-axis coordinate in the metric trends chart.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1615824000</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <para>The y-axis coordinate in the metric trends chart.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// <para>The queried metric type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE_USER_PEAK</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
