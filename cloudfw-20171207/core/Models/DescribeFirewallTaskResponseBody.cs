// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeFirewallTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsFound")]
        [Validation(Required=false)]
        public bool? IsFound { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7D5483BF-2262-586D-8706-BDDB8B42****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17151381075</para>
        /// </summary>
        [NameInMap("TaskFinishTimestamp")]
        [Validation(Required=false)]
        public string TaskFinishTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>189997648</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>egressgw</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17151361285</para>
        /// </summary>
        [NameInMap("TaskStartTimestamp")]
        [Validation(Required=false)]
        public string TaskStartTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>init</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("TaskSteps")]
        [Validation(Required=false)]
        public List<DescribeFirewallTaskResponseBodyTaskSteps> TaskSteps { get; set; }
        public class DescribeFirewallTaskResponseBodyTaskSteps : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abcd</para>
            /// </summary>
            [NameInMap("StepInfo")]
            [Validation(Required=false)]
            public string StepInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Create Firewall</para>
            /// </summary>
            [NameInMap("StepName")]
            [Validation(Required=false)]
            public string StepName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("StepProgress")]
            [Validation(Required=false)]
            public string StepProgress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>init</para>
            /// </summary>
            [NameInMap("StepStatus")]
            [Validation(Required=false)]
            public string StepStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TaskWaitingTime")]
        [Validation(Required=false)]
        public string TaskWaitingTime { get; set; }

    }

}
