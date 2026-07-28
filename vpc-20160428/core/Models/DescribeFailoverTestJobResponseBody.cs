// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeFailoverTestJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The failover test job.</para>
        /// </summary>
        [NameInMap("FailoverTestJobModel")]
        [Validation(Required=false)]
        public DescribeFailoverTestJobResponseBodyFailoverTestJobModel FailoverTestJobModel { get; set; }
        public class DescribeFailoverTestJobResponseBodyFailoverTestJobModel : TeaModel {
            /// <summary>
            /// <para>The description of the failover test job.</para>
            /// <para>The description is 0 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The failover test duration. Unit: minutes. Valid values: <b>1 to 4320</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("JobDuration")]
            [Validation(Required=false)]
            public string JobDuration { get; set; }

            /// <summary>
            /// <para>The ID of the failover test job.</para>
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
            /// <item><description><para><b>StartNow</b>: starts immediately. The failover test starts immediately after the job is created.</para>
            /// </description></item>
            /// <item><description><para><b>StartLater</b>: starts later. Only the job is created without starting the test.</para>
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
            /// <para>The resource type for the failover test. Valid values: <b>PHYSICALCONNECTION</b>: Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHYSICALCONNECTION</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The start time of the failover test job. The time is displayed in UTC in the YYYY-MM-DDThh:mm:ssZ format.</para>
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
            /// <item><description><para><b>Init</b>: pending.</para>
            /// </description></item>
            /// <item><description><para><b>Starting</b>: starting.</para>
            /// </description></item>
            /// <item><description><para><b>Testing</b>: in progress.</para>
            /// </description></item>
            /// <item><description><para><b>Stopping</b>: stopping.</para>
            /// </description></item>
            /// <item><description><para><b>Stopped</b>: completed.</para>
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
            /// <para>The end time of the failover test job. The time is displayed in UTC in the YYYY-MM-DDThh:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-21T15:00:00Z</para>
            /// </summary>
            [NameInMap("StopTime")]
            [Validation(Required=false)]
            public string StopTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C44F62BE-9CE7-4277-B117-69243F3988BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
