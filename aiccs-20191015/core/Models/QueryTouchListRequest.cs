// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTouchListRequest : TeaModel {
        /// <summary>
        /// <para>List of session IDs for term query.</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public List<string> ChannelId { get; set; }

        /// <summary>
        /// <para>Channel Type.</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public List<int?> ChannelType { get; set; }

        /// <summary>
        /// <para>The right boundary of the time range for session end. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614600500000</para>
        /// </summary>
        [NameInMap("CloseTimeEnd")]
        [Validation(Required=false)]
        public long? CloseTimeEnd { get; set; }

        /// <summary>
        /// <para>The left boundary of the time range for session end. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614600400000</para>
        /// </summary>
        [NameInMap("CloseTimeStart")]
        [Validation(Required=false)]
        public long? CloseTimeStart { get; set; }

        /// <summary>
        /// <para>Current page. The value must be greater than <b>0</b>. Default Value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Satisfaction level.</para>
        /// </summary>
        [NameInMap("EvaluationLevel")]
        [Validation(Required=false)]
        public List<int?> EvaluationLevel { get; set; }

        /// <summary>
        /// <para>Satisfaction score.</para>
        /// </summary>
        [NameInMap("EvaluationScore")]
        [Validation(Required=false)]
        public List<int?> EvaluationScore { get; set; }

        /// <summary>
        /// <para>Evaluation status.</para>
        /// </summary>
        [NameInMap("EvaluationStatus")]
        [Validation(Required=false)]
        public List<int?> EvaluationStatus { get; set; }

        /// <summary>
        /// <para>The right boundary of the time range for session start. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614599400000</para>
        /// </summary>
        [NameInMap("FirstTimeEnd")]
        [Validation(Required=false)]
        public long? FirstTimeEnd { get; set; }

        /// <summary>
        /// <para>The left boundary of the time range for session start. UNIX timestamp format (unit: ms).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614596400000</para>
        /// </summary>
        [NameInMap("FirstTimeStart")]
        [Validation(Required=false)]
        public long? FirstTimeStart { get; set; }

        /// <summary>
        /// <para>Artificial Intelligence Cloud Call Service (AICCS) instance ID.<br>You can obtain it from <b>Instance Management</b> in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>List of membership IDs to query.</para>
        /// </summary>
        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public List<long?> MemberId { get; set; }

        /// <summary>
        /// <para>A list of membership names to query.</para>
        /// </summary>
        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public List<string> MemberName { get; set; }

        /// <summary>
        /// <para>Number of entries per page. The value must be greater than <b>0</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>List of inbound skill group IDs.</para>
        /// </summary>
        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public List<long?> QueueId { get; set; }

        /// <summary>
        /// <para>A list of service agent IDs to query.</para>
        /// </summary>
        [NameInMap("ServicerId")]
        [Validation(Required=false)]
        public List<long?> ServicerId { get; set; }

        /// <summary>
        /// <para>List of service agent names to query.</para>
        /// </summary>
        [NameInMap("ServicerName")]
        [Validation(Required=false)]
        public List<string> ServicerName { get; set; }

        /// <summary>
        /// <para>List of touch IDs for term query.</para>
        /// </summary>
        [NameInMap("TouchId")]
        [Validation(Required=false)]
        public List<long?> TouchId { get; set; }

        /// <summary>
        /// <para>Touch type.</para>
        /// </summary>
        [NameInMap("TouchType")]
        [Validation(Required=false)]
        public List<int?> TouchType { get; set; }

    }

}
