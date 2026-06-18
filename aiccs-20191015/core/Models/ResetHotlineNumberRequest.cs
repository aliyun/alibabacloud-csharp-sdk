// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ResetHotlineNumberRequest : TeaModel {
        /// <summary>
        /// <para>Number description.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>热线号码</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the number is used for inbound calls.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableInbound")]
        [Validation(Required=false)]
        public bool? EnableInbound { get; set; }

        /// <summary>
        /// <para>Whether inbound call satisfaction evaluation is enabled.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableInboundEvaluation")]
        [Validation(Required=false)]
        public bool? EnableInboundEvaluation { get; set; }

        /// <summary>
        /// <para>Whether used for outbound calls.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableOutbound")]
        [Validation(Required=false)]
        public bool? EnableOutbound { get; set; }

        /// <summary>
        /// <para>Indicates whether outbound satisfaction evaluation is enabled.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableOutboundEvaluation")]
        [Validation(Required=false)]
        public bool? EnableOutboundEvaluation { get; set; }

        /// <summary>
        /// <para>Satisfaction level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: Two-level (Satisfied, Not Satisfied)</description></item>
        /// <item><description><b>3</b>: Three-level (Satisfied, Neutral, Not Satisfied)</description></item>
        /// <item><description><b>4</b>: Four-level (Very Satisfied, Satisfied, Neutral, Not Satisfied)</description></item>
        /// <item><description><b>5</b>: Five-level (Very Satisfied, Satisfied, Neutral, Not Satisfied, Very Poor)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("EvaluationLevel")]
        [Validation(Required=false)]
        public int? EvaluationLevel { get; set; }

        /// <summary>
        /// <para>Hotline number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571********</para>
        /// </summary>
        [NameInMap("HotlineNumber")]
        [Validation(Required=false)]
        public string HotlineNumber { get; set; }

        /// <summary>
        /// <para>The IVR flow ID for inbound calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("InboundFlowId")]
        [Validation(Required=false)]
        public long? InboundFlowId { get; set; }

        /// <summary>
        /// <para>The Artificial Intelligence Cloud Call Service (AICCS) instance ID. You can obtain it from the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether outbound calls apply to all departments.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OutboundAllDepart")]
        [Validation(Required=false)]
        public bool? OutboundAllDepart { get; set; }

        /// <summary>
        /// <para>Outbound call effective scope.</para>
        /// </summary>
        [NameInMap("OutboundRangeList")]
        [Validation(Required=false)]
        public List<ResetHotlineNumberRequestOutboundRangeList> OutboundRangeList { get; set; }
        public class ResetHotlineNumberRequestOutboundRangeList : TeaModel {
            /// <summary>
            /// <para>Effective department ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("DepartmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            /// <summary>
            /// <para>List of effective skill groups.</para>
            /// <remarks>
            /// <para>If the skill group list is empty, the setting applies to the entire department. Otherwise, it applies only to the specified skill groups under the department.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("GroupIdList")]
            [Validation(Required=false)]
            public List<long?> GroupIdList { get; set; }

        }

    }

}
