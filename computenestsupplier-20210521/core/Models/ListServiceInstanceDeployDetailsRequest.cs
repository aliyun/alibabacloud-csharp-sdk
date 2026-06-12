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
        /// <para>Example: +08:00</para>
        /// <para>Valid values: -12:59 to +13:00</para>
        /// 
        /// <b>Example:</b>
        /// <para>+08:00</para>
        /// </summary>
        [NameInMap("CycleTimeZone")]
        [Validation(Required=false)]
        public string CycleTimeZone { get; set; }

        /// <summary>
        /// <para>The aggregation period. If you do not specify this parameter, the system queries the details.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Year</para>
        /// </description></item>
        /// <item><description><para>Month</para>
        /// </description></item>
        /// <item><description><para>Day</para>
        /// </description></item>
        /// <item><description><para>All</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("CycleType")]
        [Validation(Required=false)]
        public string CycleType { get; set; }

        /// <summary>
        /// <para>The name of the dimension. This corresponds to the GROUP BY clause in SQL.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>UserId</para>
        /// </description></item>
        /// <item><description><para>ServiceId</para>
        /// </description></item>
        /// <item><description><para>ServiceVersion</para>
        /// </description></item>
        /// <item><description><para>ServiceInstanceId</para>
        /// </description></item>
        /// <item><description><para>DeploySucceeded</para>
        /// </description></item>
        /// <item><description><para>ErrorType</para>
        /// </description></item>
        /// <item><description><para>ErrorCode</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public List<string> Dimension { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <para>Use UTC+0 time in the yyyy-MM-ddTHH:mmZ format.</para>
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
            /// <para>The name of the filter. This corresponds to the WHERE clause in SQL.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>UserId</para>
            /// </description></item>
            /// <item><description><para>ServiceId</para>
            /// </description></item>
            /// <item><description><para>ServiceVersion</para>
            /// </description></item>
            /// <item><description><para>ServiceInstanceId</para>
            /// </description></item>
            /// <item><description><para>DeploySucceeded (The value can be True or False. The value is case-insensitive.)</para>
            /// </description></item>
            /// <item><description><para>ErrorType</para>
            /// </description></item>
            /// <item><description><para>ErrorCode</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>A list of filter values.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAZbOYA+x9UgM6xrgcMqFUjk=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query.</para>
        /// <para>Use UTC+0 time in the yyyy-MM-ddTHH:mmZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-25T02:23:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
