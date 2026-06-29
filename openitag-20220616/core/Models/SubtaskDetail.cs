// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class SubtaskDetail : TeaModel {
        /// <summary>
        /// <para>is discardable</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CanDiscard")]
        [Validation(Required=false)]
        public bool? CanDiscard { get; set; }

        /// <summary>
        /// <para>Can assign</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CanReassign")]
        [Validation(Required=false)]
        public bool? CanReassign { get; set; }

        /// <summary>
        /// <para>is releasable</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CanRelease")]
        [Validation(Required=false)]
        public bool? CanRelease { get; set; }

        /// <summary>
        /// <para>current File Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>MARK</para>
        /// </summary>
        [NameInMap("CurrentWorkNode")]
        [Validation(Required=false)]
        public string CurrentWorkNode { get; set; }

        /// <summary>
        /// <para>extra parameters</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ExtConfigs")]
        [Validation(Required=false)]
        public string ExtConfigs { get; set; }

        /// <summary>
        /// <para>List of items in the sub-job</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<SubtaskDetailItems> Items { get; set; }
        public class SubtaskDetailItems : TeaModel {
            /// <summary>
            /// <para>Abandon mark</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("AbandonFlag")]
            [Validation(Required=false)]
            public bool? AbandonFlag { get; set; }

            /// <summary>
            /// <para>discard reason</para>
            /// 
            /// <b>Example:</b>
            /// <para>原始数据错误</para>
            /// </summary>
            [NameInMap("AbandonRemark")]
            [Validation(Required=false)]
            public string AbandonRemark { get; set; }

            /// <summary>
            /// <para>Date ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1957578084</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>feedback mark</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("FeedbackFlag")]
            [Validation(Required=false)]
            public bool? FeedbackFlag { get; set; }

            /// <summary>
            /// <para>Validate feedback</para>
            /// 
            /// <b>Example:</b>
            /// <para>标注内容合格</para>
            /// </summary>
            [NameInMap("FeedbackRemark")]
            [Validation(Required=false)]
            public string FeedbackRemark { get; set; }

            /// <summary>
            /// <para>Failed mark</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("FixedFlag")]
            [Validation(Required=false)]
            public bool? FixedFlag { get; set; }

            /// <summary>
            /// <para>Is assigned to me</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Mine")]
            [Validation(Required=false)]
            public long? Mine { get; set; }

            /// <summary>
            /// <para>skip mark</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("RejectFlag")]
            [Validation(Required=false)]
            public bool? RejectFlag { get; set; }

            /// <summary>
            /// <para>status</para>
            /// 
            /// <b>Example:</b>
            /// <para>HANDLING</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>Weight</para>
            /// 
            /// <b>Example:</b>
            /// <para>311011</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public long? Weight { get; set; }

        }

        /// <summary>
        /// <para>status</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Subtask ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1500***457270333440</para>
        /// </summary>
        [NameInMap("SubtaskId")]
        [Validation(Required=false)]
        public string SubtaskId { get; set; }

        /// <summary>
        /// <para>parent job ID of the sub-job</para>
        /// 
        /// <b>Example:</b>
        /// <para>1511***994667356160</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Job weight</para>
        /// 
        /// <b>Example:</b>
        /// <para>631548</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public long? Weight { get; set; }

        /// <summary>
        /// <para>Current edge zone status</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("WorkNodeState")]
        [Validation(Required=false)]
        public string WorkNodeState { get; set; }

        /// <summary>
        /// <para>list of annotators assigned to the sub-job</para>
        /// </summary>
        [NameInMap("Workforce")]
        [Validation(Required=false)]
        public List<Workforce> Workforce { get; set; }

    }

}
