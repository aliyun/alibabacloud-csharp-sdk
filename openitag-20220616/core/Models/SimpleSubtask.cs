// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class SimpleSubtask : TeaModel {
        /// <summary>
        /// <para>List of items for subtasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<SimpleSubtaskItems> Items { get; set; }
        public class SimpleSubtaskItems : TeaModel {
            /// <summary>
            /// <para>Abandon flag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AbandonFlag")]
            [Validation(Required=false)]
            public bool? AbandonFlag { get; set; }

            /// <summary>
            /// <para>Abandonment remark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>原始数据有问题</para>
            /// </summary>
            [NameInMap("AbandonRemark")]
            [Validation(Required=false)]
            public string AbandonRemark { get; set; }

            /// <summary>
            /// <para>Date ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>175296157992643****</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>Feedback flag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FeedbackFlag")]
            [Validation(Required=false)]
            public bool? FeedbackFlag { get; set; }

            /// <summary>
            /// <para>Validation feedback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>验收完成</para>
            /// </summary>
            [NameInMap("FeedbackRemark")]
            [Validation(Required=false)]
            public string FeedbackRemark { get; set; }

            /// <summary>
            /// <para>Failed mark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FixedFlag")]
            [Validation(Required=false)]
            public bool? FixedFlag { get; set; }

            /// <summary>
            /// <para>Data item ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15116***94667356160</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            /// <summary>
            /// <para>Assigned to me:</para>
            /// <list type="bullet">
            /// <item><description>0: Not assigned to me.</description></item>
            /// <item><description>1: Assigned to me.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Mine")]
            [Validation(Required=false)]
            public long? Mine { get; set; }

            /// <summary>
            /// <para>Skip flag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RejectFlag")]
            [Validation(Required=false)]
            public bool? RejectFlag { get; set; }

            /// <summary>
            /// <para>Status:</para>
            /// <list type="bullet">
            /// <item><description>INIT: Initial status.</description></item>
            /// <item><description>TOPUBLISH: Pending publish.</description></item>
            /// <item><description>CREATED: Created.</description></item>
            /// <item><description>HANDLING: In progress.</description></item>
            /// <item><description>VOTING: Voting in progress.</description></item>
            /// <item><description>FINISHED: Completed.</description></item>
            /// <item><description>FAIL: Failed.</description></item>
            /// <item><description>EXPIRE: Timeout.</description></item>
            /// <item><description>DISCARDED: Passively abandoned.</description></item>
            /// <item><description>DISABLE: Actively abandoned.</description></item>
            /// <item><description>LOCKED: Edit Lock.</description></item>
            /// <item><description>OFFLINE: Unpublished.</description></item>
            /// <item><description>MERGING: Merging results.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HANDLING</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>Weight.</para>
            /// 
            /// <b>Example:</b>
            /// <para>311011</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public long? Weight { get; set; }

        }

        /// <summary>
        /// <para>Status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Subtask ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1500***457270333440</para>
        /// </summary>
        [NameInMap("SubtaskId")]
        [Validation(Required=false)]
        public long? SubtaskId { get; set; }

    }

}
