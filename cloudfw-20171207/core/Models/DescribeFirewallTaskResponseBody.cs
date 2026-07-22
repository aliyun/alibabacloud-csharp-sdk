// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeFirewallTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the task exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsFound")]
        [Validation(Required=false)]
        public bool? IsFound { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D5483BF-2262-586D-8706-BDDB8B42****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the task was completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17151381075</para>
        /// </summary>
        [NameInMap("TaskFinishTimestamp")]
        [Validation(Required=false)]
        public string TaskFinishTimestamp { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>189997648</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>egressgw</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The time when the task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17151361285</para>
        /// </summary>
        [NameInMap("TaskStartTimestamp")]
        [Validation(Required=false)]
        public string TaskStartTimestamp { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>init</b></para>
        /// </description></item>
        /// <item><description><para><b>running</b></para>
        /// </description></item>
        /// <item><description><para><b>finished</b></para>
        /// </description></item>
        /// <item><description><para><b>rollback</b></para>
        /// </description></item>
        /// <item><description><para><b>rollbackDone</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>init</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The task steps.</para>
        /// </summary>
        [NameInMap("TaskSteps")]
        [Validation(Required=false)]
        public List<DescribeFirewallTaskResponseBodyTaskSteps> TaskSteps { get; set; }
        public class DescribeFirewallTaskResponseBodyTaskSteps : TeaModel {
            /// <summary>
            /// <para>The task information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcd</para>
            /// </summary>
            [NameInMap("StepInfo")]
            [Validation(Required=false)]
            public string StepInfo { get; set; }

            /// <summary>
            /// <para>The name of the Cloud Firewall security step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Create Firewall</para>
            /// </summary>
            [NameInMap("StepName")]
            [Validation(Required=false)]
            public string StepName { get; set; }

            /// <summary>
            /// <para>The progress of the task step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("StepProgress")]
            [Validation(Required=false)]
            public string StepProgress { get; set; }

            /// <summary>
            /// <para>The status of the task step. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>init</b> </para>
            /// </description></item>
            /// <item><description><para><b>running</b></para>
            /// </description></item>
            /// <item><description><para><b>finished</b></para>
            /// </description></item>
            /// <item><description><para><b>failed</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>init</para>
            /// </summary>
            [NameInMap("StepStatus")]
            [Validation(Required=false)]
            public string StepStatus { get; set; }

        }

        /// <summary>
        /// <para>The waiting time, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TaskWaitingTime")]
        [Validation(Required=false)]
        public string TaskWaitingTime { get; set; }

    }

}
