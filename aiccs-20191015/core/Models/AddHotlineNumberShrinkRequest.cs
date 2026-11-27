// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AddHotlineNumberShrinkRequest : TeaModel {
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
        /// <para>The satisfaction level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: Level 2 (Satisfied, Dissatisfied).</description></item>
        /// <item><description><b>3</b>: Level 3 (Satisfied, Neutral, Dissatisfied).</description></item>
        /// <item><description><b>4</b>: Level 4 (Very satisfied, Satisfied, Neutral, Dissatisfied).</description></item>
        /// <item><description><b>5</b>: Level 5 (Very satisfied, Satisfied, Neutral, Dissatisfied, Very dissatisfied).</description></item>
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
        /// <para>05710000****</para>
        /// </summary>
        [NameInMap("HotlineNumber")]
        [Validation(Required=false)]
        public string HotlineNumber { get; set; }

        /// <summary>
        /// <para>The ID of the inbound IVR flow. You can obtain the ID from the Hotline &gt; Channel Access &gt; IVR Flow Management page in the SaaS workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("InboundFlowId")]
        [Validation(Required=false)]
        public long? InboundFlowId { get; set; }

        /// <summary>
        /// <para>The Artificial Intelligence Cloud Call Service instance ID. You can obtain the ID from the Artificial Intelligence Cloud Call Service console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether outbound calls apply to all departments under the instance.</para>
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
        public string OutboundRangeListShrink { get; set; }

    }

}
