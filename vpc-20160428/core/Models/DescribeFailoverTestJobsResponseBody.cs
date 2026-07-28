// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeFailoverTestJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of failover test jobs.</para>
        /// </summary>
        [NameInMap("FailoverTestJobList")]
        [Validation(Required=false)]
        public List<DescribeFailoverTestJobsResponseBodyFailoverTestJobList> FailoverTestJobList { get; set; }
        public class DescribeFailoverTestJobsResponseBodyFailoverTestJobList : TeaModel {
            /// <summary>
            /// <para>The description of the failover test job.</para>
            /// <para>The description is 0 to 256 characters in length and cannot start with <b>http://</b> or <b>https://</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The test duration. Unit: minutes. Valid values: <b>1 to 4320</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("JobDuration")]
            [Validation(Required=false)]
            public string JobDuration { get; set; }

            /// <summary>
            /// <para>The failover test job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ftj-bp1yh6mvi13aq3g8w****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The failover test type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>StartNow</b>: The test starts immediately after the failover test job is created.</para>
            /// </description></item>
            /// <item><description><para><b>StartLater</b>: Only the test job is created. The test is not started.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>StartNow</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The name of the failover test job.</para>
            /// <para>The name is 0 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of failover test resource IDs.</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public List<string> ResourceId { get; set; }

            /// <summary>
            /// <para>The failover test resource type. Valid values: <b>PHYSICALCONNECTION</b>: Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHYSICALCONNECTION</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The start time of the failover test job. The time is displayed in UTC in the YYYY-MM-DDThh:mm:ssZ format based on the ISO 8601 standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-21T14:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the failover test job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Init</b>: Pending.</para>
            /// </description></item>
            /// <item><description><para><b>Starting</b>: Starting.</para>
            /// </description></item>
            /// <item><description><para><b>Testing</b>: In progress.</para>
            /// </description></item>
            /// <item><description><para><b>Stopping</b>: Stopping.</para>
            /// </description></item>
            /// <item><description><para><b>Stopped</b>: Completed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Init</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The end time of the failover test job. The time is displayed in UTC in the YYYY-MM-DDThh:mm:ssZ format based on the ISO 8601 standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-21T15:00:00Z</para>
            /// </summary>
            [NameInMap("StopTime")]
            [Validation(Required=false)]
            public string StopTime { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page for paginated queries. Valid values: <b>1 to 100</b>. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Leave this parameter empty for the first query or if no next query exists.</para>
        /// </description></item>
        /// <item><description><para>If a next query exists, set this parameter to the NextToken value returned by the previous API call.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
