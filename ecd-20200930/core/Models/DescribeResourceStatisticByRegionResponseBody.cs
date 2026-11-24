// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeResourceStatisticByRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics information.</para>
        /// </summary>
        [NameInMap("Statistic")]
        [Validation(Required=false)]
        public DescribeResourceStatisticByRegionResponseBodyStatistic Statistic { get; set; }
        public class DescribeResourceStatisticByRegionResponseBodyStatistic : TeaModel {
            /// <summary>
            /// <para>The statistics by region.</para>
            /// </summary>
            [NameInMap("RegionStatistics")]
            [Validation(Required=false)]
            public List<DescribeResourceStatisticByRegionResponseBodyStatisticRegionStatistics> RegionStatistics { get; set; }
            public class DescribeResourceStatisticByRegionResponseBodyStatisticRegionStatistics : TeaModel {
                /// <summary>
                /// <para>The number of assigned users in the current region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AssignedEndUserCount")]
                [Validation(Required=false)]
                public long? AssignedEndUserCount { get; set; }

                /// <summary>
                /// <para>The number of connected users in the current region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ConnectedEndUserCount")]
                [Validation(Required=false)]
                public long? ConnectedEndUserCount { get; set; }

                /// <summary>
                /// <para>The number of cloud desktops in the current region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DesktopCount")]
                [Validation(Required=false)]
                public long? DesktopCount { get; set; }

                /// <summary>
                /// <para>The number of shared cloud desktops in the current region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DesktopGroupCount")]
                [Validation(Required=false)]
                public long? DesktopGroupCount { get; set; }

                /// <summary>
                /// <para>The number of network packages in the current region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NetworkPackageCount")]
                [Validation(Required=false)]
                public long? NetworkPackageCount { get; set; }

                /// <summary>
                /// <para>The number of policy groups in the current region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PolicyGroupCount")]
                [Validation(Required=false)]
                public long? PolicyGroupCount { get; set; }

                /// <summary>
                /// <para>The region ID. You can call the <a href="https://next.api.aliyun.com/document/ecd/2020-09-30/DescribeRegions">DescribeRegions</a> operation to query the regions supported by WUYING Workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

    }

}
