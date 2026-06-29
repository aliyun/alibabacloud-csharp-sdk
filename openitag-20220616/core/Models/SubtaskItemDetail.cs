// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class SubtaskItemDetail : TeaModel {
        /// <summary>
        /// <para>List of annotation results</para>
        /// </summary>
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public List<SubtaskItemDetailAnnotations> Annotations { get; set; }
        public class SubtaskItemDetailAnnotations : TeaModel {
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
            /// <para>Abandonment remark</para>
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
            /// <para>Feedback mark</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("FeedbackFlag")]
            [Validation(Required=false)]
            public bool? FeedbackFlag { get; set; }

            /// <summary>
            /// <para>Validation feedback</para>
            /// 
            /// <b>Example:</b>
            /// <para>验收成功/所有投票结果都未被采纳</para>
            /// </summary>
            [NameInMap("FeedbackRemark")]
            [Validation(Required=false)]
            public string FeedbackRemark { get; set; }

            /// <summary>
            /// <para>Failure mark</para>
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
            /// <para>Skip mark</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("RejectFlag")]
            [Validation(Required=false)]
            public bool? RejectFlag { get; set; }

            /// <summary>
            /// <para>Status</para>
            /// 
            /// <b>Example:</b>
            /// <para>HANDLING</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>weight</para>
            /// 
            /// <b>Example:</b>
            /// <para>311011</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public long? Weight { get; set; }

        }

        /// <summary>
        /// <para>data source</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public Dictionary<string, object> DataSource { get; set; }

        /// <summary>
        /// <para>Item ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1500***47176994816</para>
        /// </summary>
        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

    }

}
