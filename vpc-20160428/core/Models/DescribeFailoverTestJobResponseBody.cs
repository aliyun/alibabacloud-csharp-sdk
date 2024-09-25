// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeFailoverTestJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The failover test.</para>
        /// </summary>
        [NameInMap("FailoverTestJobModel")]
        [Validation(Required=false)]
        public DescribeFailoverTestJobResponseBodyFailoverTestJobModel FailoverTestJobModel { get; set; }
        public class DescribeFailoverTestJobResponseBodyFailoverTestJobModel : TeaModel {
            /// <summary>
            /// <para>The description of the failover test.</para>
            /// <para>The description must be 0 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The duration of the failover test. Unit: minutes. Valid values: <b>1 to 4320</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("JobDuration")]
            [Validation(Required=false)]
            public string JobDuration { get; set; }

            /// <summary>
            /// <para>The ID of the failover test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ftj-xxxxxxxxx</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>Indicates whether the failover test is performed immediately. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>StartNow</b></description></item>
            /// <item><description><b>StartLater</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>StartNow</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The name of the failover test.</para>
            /// <para>The name must be 0 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The IDs of failover test resources.</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public List<string> ResourceId { get; set; }

            /// <summary>
            /// <para>The type of failover test resource. Only <b>PHYSICALCONNECTION</b> is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHYSICALCONNECTION</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The start time of the failover test. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-21T14:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the failover test. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Init</b></description></item>
            /// <item><description><b>Starting</b></description></item>
            /// <item><description><b>Testing</b></description></item>
            /// <item><description><b>Stopping</b></description></item>
            /// <item><description><b>Stopped</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Init</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The end time of the failover test. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
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
