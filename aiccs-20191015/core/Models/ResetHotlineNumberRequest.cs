// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ResetHotlineNumberRequest : TeaModel {
        /// <summary>
        /// <para>The description of the hotline number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hotline number</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the hotline number is used for inbound calls.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableInbound")]
        [Validation(Required=false)]
        public bool? EnableInbound { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the satisfaction survey for inbound calls.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableInboundEvaluation")]
        [Validation(Required=false)]
        public bool? EnableInboundEvaluation { get; set; }

        /// <summary>
        /// <para>Specifies whether the hotline number is used for outbound calls.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableOutbound")]
        [Validation(Required=false)]
        public bool? EnableOutbound { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the satisfaction survey for outbound calls.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableOutboundEvaluation")]
        [Validation(Required=false)]
        public bool? EnableOutboundEvaluation { get; set; }

        /// <summary>
        /// <para>The satisfaction survey level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: level 2 (satisfied, dissatisfied)</description></item>
        /// <item><description><b>3</b>: level 3 (satisfied, neutral, dissatisfied)</description></item>
        /// <item><description><b>4</b>: level 4 (very satisfied, satisfied, neutral, dissatisfied)</description></item>
        /// <item><description><b>5</b>: level 5 (very satisfied, satisfied, neutral, dissatisfied, very poor)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("EvaluationLevel")]
        [Validation(Required=false)]
        public int? EvaluationLevel { get; set; }

        /// <summary>
        /// <para>The hotline number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571********</para>
        /// </summary>
        [NameInMap("HotlineNumber")]
        [Validation(Required=false)]
        public string HotlineNumber { get; set; }

        /// <summary>
        /// <para>The ID of the inbound Interactive Voice Response (IVR) flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("InboundFlowId")]
        [Validation(Required=false)]
        public long? InboundFlowId { get; set; }

        /// <summary>
        /// <para>Instance ID of the Artificial Intelligence Cloud Call Service (AICCS) instance. You can obtain instance ID from the AICCS console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether outbound calls apply to all departments.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OutboundAllDepart")]
        [Validation(Required=false)]
        public bool? OutboundAllDepart { get; set; }

        /// <summary>
        /// <para>The effective scope of outbound calls.</para>
        /// </summary>
        [NameInMap("OutboundRangeList")]
        [Validation(Required=false)]
        public List<ResetHotlineNumberRequestOutboundRangeList> OutboundRangeList { get; set; }
        public class ResetHotlineNumberRequestOutboundRangeList : TeaModel {
            /// <summary>
            /// <para>The ID of the effective department.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("DepartmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            /// <summary>
            /// <para>The list of effective skill groups.</para>
            /// <remarks>
            /// <para>If the skill group list is empty, the configuration applies to the entire department. Otherwise, it applies only to the specified skill groups under the department.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("GroupIdList")]
            [Validation(Required=false)]
            public List<long?> GroupIdList { get; set; }

        }

    }

}
