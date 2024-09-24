// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeComputeResourceUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The queried resource usage.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeComputeResourceUsageResponseBodyData Data { get; set; }
        public class DescribeComputeResourceUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AnalyticDB compute unit (ACU) usage of the cluster.</para>
            /// </summary>
            [NameInMap("AcuInfo")]
            [Validation(Required=false)]
            public List<DescribeComputeResourceUsageResponseBodyDataAcuInfo> AcuInfo { get; set; }
            public class DescribeComputeResourceUsageResponseBodyDataAcuInfo : TeaModel {
                /// <summary>
                /// <para>The resource usage metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>TotalAcuNumber</c>: the total number of ACUs.</description></item>
                /// <item><description><c>ReservedAcuNumber</c>: the number of ACUs for the reserved resources.</description></item>
                /// <item><description><c>ReservedAcuUsageNumber</c>: the number of ACUs for the reserved resources that are used.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TotalAcuNumber</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The values of the metric at specific points in time.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-clusterxxx</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The end time of the query. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-07T02:37:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <para>The type of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>interative</para>
            /// </summary>
            [NameInMap("ResourceGroupType")]
            [Validation(Required=false)]
            public string ResourceGroupType { get; set; }

            /// <summary>
            /// <para>The start time of the query. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-24T07:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEAW</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
