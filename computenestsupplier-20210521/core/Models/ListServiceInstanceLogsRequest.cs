// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceInstanceLogsRequest : TeaModel {
        /// <summary>
        /// <para>The filters.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListServiceInstanceLogsRequestFilter> Filter { get; set; }
        public class ListServiceInstanceLogsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The name of the filter condition.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>StartTime</para>
            /// </description></item>
            /// <item><description><para>EndTime</para>
            /// </description></item>
            /// <item><description><para>ApplicationGroupName</para>
            /// </description></item>
            /// <item><description><para>ResourceName</para>
            /// </description></item>
            /// <item><description><para>EventName</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>StartTime</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The values for the filter condition. You can specify up to 10 values.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The source of the logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>application: Logs from the application.</para>
        /// </description></item>
        /// <item><description><para>computeNest: Logs from Compute Nest.</para>
        /// </description></item>
        /// <item><description><para>ros: Logs from Resource Orchestration Service (ROS).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>computeNest</para>
        /// </summary>
        [NameInMap("LogSource")]
        [Validation(Required=false)]
        public string LogSource { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>livelog</para>
        /// </summary>
        [NameInMap("Logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that specifies the next page of results to return. Set this parameter to the NextToken value from a previous response to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBBAAfu+XtuBE55iRLHEYYuojI4=</para>
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
        /// <para>The service instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-70a3b15bb626435b****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Ascending</b>: Ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>Descending</b> (default): Descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ascending</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
