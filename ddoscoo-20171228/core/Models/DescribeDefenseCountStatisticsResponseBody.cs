// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDefenseCountStatisticsResponseBody : TeaModel {
        [NameInMap("DefenseCountStatistics")]
        [Validation(Required=false)]
        public DescribeDefenseCountStatisticsResponseBodyDefenseCountStatistics DefenseCountStatistics { get; set; }
        public class DescribeDefenseCountStatisticsResponseBodyDefenseCountStatistics : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DefenseCountTotalUsageOfCurrentMonth")]
            [Validation(Required=false)]
            public int? DefenseCountTotalUsageOfCurrentMonth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("FlowPackCountRemain")]
            [Validation(Required=false)]
            public int? FlowPackCountRemain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxUsableDefenseCountCurrentMonth")]
            [Validation(Required=false)]
            public int? MaxUsableDefenseCountCurrentMonth { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
