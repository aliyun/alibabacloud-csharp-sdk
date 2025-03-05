// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceInstanceDeployDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The time zone.</para>
        /// <para>Reference Format: &quot;+08:00&quot;</para>
        /// <para>Valid Range: &quot;-12:59&quot; to &quot;+13:00&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <para>+08:00</para>
        /// </summary>
        [NameInMap("CycleTimeZone")]
        [Validation(Required=false)]
        public string CycleTimeZone { get; set; }

        /// <summary>
        /// <para>Determines the time period over which data is aggregated. If no aggregation dimension is specified, the query defaults to providing detailed, unaggregated results.</para>
        /// <para>Optional Values:</para>
        /// <list type="bullet">
        /// <item><description>Year</description></item>
        /// <item><description>Month</description></item>
        /// <item><description>Day</description></item>
        /// <item><description>All</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("CycleType")]
        [Validation(Required=false)]
        public string CycleType { get; set; }

        /// <summary>
        /// <para>The dimension names. (Equivalent to SQL\&quot;s GROUP BY Clause)
        /// Optional Values:</para>
        /// <list type="bullet">
        /// <item><description>UserId</description></item>
        /// <item><description>ServiceId</description></item>
        /// <item><description>ServiceVersion</description></item>
        /// <item><description>ServiceInstanceId</description></item>
        /// <item><description>DeploySucceeded</description></item>
        /// <item><description>ErrorType</description></item>
        /// <item><description>ErrorCode</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public List<string> Dimension { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-31T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The filter.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListServiceInstanceDeployDetailsRequestFilter> Filter { get; set; }
        public class ListServiceInstanceDeployDetailsRequestFilter : TeaModel {
            /// <summary>
            /// <para>Filter Value Names (Equivalent to SQL\&quot;s WHERE Clause)</para>
            /// <para>Available Options:</para>
            /// <list type="bullet">
            /// <item><description>UserId</description></item>
            /// <item><description>ServiceId</description></item>
            /// <item><description>ServiceVersion</description></item>
            /// <item><description>ServiceInstanceId</description></item>
            /// <item><description>DeploySucceeded (Accepts True or False and case-insensitive)</description></item>
            /// <item><description>ErrorType</description></item>
            /// <item><description>ErrorCode</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>A value of the filter condition.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAZbOYA+x9UgM6xrgcMqFUjk=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-25T02:23:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
