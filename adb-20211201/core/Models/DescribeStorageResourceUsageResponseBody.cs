// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeStorageResourceUsageResponseBody : TeaModel {
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
        public DescribeStorageResourceUsageResponseBodyData Data { get; set; }
        public class DescribeStorageResourceUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AnalyticDB compute unit (ACU) usage of the cluster.</para>
            /// </summary>
            [NameInMap("AcuInfo")]
            [Validation(Required=false)]
            public List<DescribeStorageResourceUsageResponseBodyDataAcuInfo> AcuInfo { get; set; }
            public class DescribeStorageResourceUsageResponseBodyDataAcuInfo : TeaModel {
                /// <summary>
                /// <para>The resource usage metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>TotalAcuNumber</c>: the total number of ACUs.</description></item>
                /// <item><description><c>ReservedAcuNumber</c>: the number of ACUs for the reserved resources.</description></item>
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
            /// <para>amv-bp1bg858bo8c****</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The end time of the query. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-23T01:06:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-22T01:06:00Z</para>
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
