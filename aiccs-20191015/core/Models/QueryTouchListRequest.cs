// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTouchListRequest : TeaModel {
        /// <summary>
        /// <para>The list of session IDs to query exactly.</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public List<string> ChannelId { get; set; }

        /// <summary>
        /// <para>The channel type.</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public List<int?> ChannelType { get; set; }

        /// <summary>
        /// <para>The end of the time range for session end time. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614600500000</para>
        /// </summary>
        [NameInMap("CloseTimeEnd")]
        [Validation(Required=false)]
        public long? CloseTimeEnd { get; set; }

        /// <summary>
        /// <para>The start of the time range for session end time. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614600400000</para>
        /// </summary>
        [NameInMap("CloseTimeStart")]
        [Validation(Required=false)]
        public long? CloseTimeStart { get; set; }

        /// <summary>
        /// <para>The current page number. The value must be greater than <b>0</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The satisfaction level.</para>
        /// </summary>
        [NameInMap("EvaluationLevel")]
        [Validation(Required=false)]
        public List<int?> EvaluationLevel { get; set; }

        /// <summary>
        /// <para>The satisfaction score.</para>
        /// </summary>
        [NameInMap("EvaluationScore")]
        [Validation(Required=false)]
        public List<int?> EvaluationScore { get; set; }

        /// <summary>
        /// <para>The evaluation status.</para>
        /// </summary>
        [NameInMap("EvaluationStatus")]
        [Validation(Required=false)]
        public List<int?> EvaluationStatus { get; set; }

        /// <summary>
        /// <para>The end of the time range for session start time. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614599400000</para>
        /// </summary>
        [NameInMap("FirstTimeEnd")]
        [Validation(Required=false)]
        public long? FirstTimeEnd { get; set; }

        /// <summary>
        /// <para>The start of the time range for session start time. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614596400000</para>
        /// </summary>
        [NameInMap("FirstTimeStart")]
        [Validation(Required=false)]
        public long? FirstTimeStart { get; set; }

        /// <summary>
        /// <para>The ID of the Artificial Intelligence Cloud Call Service (AICCS) instance.
        /// You can obtain the instance ID from <b>Instance Management</b> in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of member IDs to query.</para>
        /// </summary>
        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public List<long?> MemberId { get; set; }

        /// <summary>
        /// <para>The list of member names to query.</para>
        /// </summary>
        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public List<string> MemberName { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The value must be greater than <b>0</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of inbound skill group IDs.</para>
        /// </summary>
        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public List<long?> QueueId { get; set; }

        /// <summary>
        /// <para>The list of agent IDs to query.</para>
        /// </summary>
        [NameInMap("ServicerId")]
        [Validation(Required=false)]
        public List<long?> ServicerId { get; set; }

        /// <summary>
        /// <para>The list of agent names to query.</para>
        /// </summary>
        [NameInMap("ServicerName")]
        [Validation(Required=false)]
        public List<string> ServicerName { get; set; }

        /// <summary>
        /// <para>The list of contact IDs to query exactly.</para>
        /// </summary>
        [NameInMap("TouchId")]
        [Validation(Required=false)]
        public List<long?> TouchId { get; set; }

        /// <summary>
        /// <para>The contact type.</para>
        /// </summary>
        [NameInMap("TouchType")]
        [Validation(Required=false)]
        public List<int?> TouchType { get; set; }

    }

}
