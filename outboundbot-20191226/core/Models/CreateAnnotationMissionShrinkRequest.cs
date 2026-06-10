// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateAnnotationMissionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID.</para>
        /// <remarks>
        /// <para>You can obtain this ID from the \<c>DescribeInstance\\</c> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1168702</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The workspace key.</para>
        /// <remarks>
        /// <para>You can obtain this key from the \<c>DescribeInstance\\</c> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>9137ab9c27044921860030adf8590ec4_p_outbound_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The data type of the annotation task.</para>
        /// <list type="bullet">
        /// <item><description>1: Outbound call</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AnnotationMissionDataSourceType")]
        [Validation(Required=false)]
        public int? AnnotationMissionDataSourceType { get; set; }

        /// <summary>
        /// <para>The list of annotation data sources.</para>
        /// <remarks>
        /// <para>This parameter has the same function as \<c>AnnotationMissionDebugDataSourceListJsonString\\</c>. You can specify either of them.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AnnotationMissionDebugDataSourceList")]
        [Validation(Required=false)]
        public string AnnotationMissionDebugDataSourceListShrink { get; set; }

        /// <summary>
        /// <para>The JSON string for the test data.</para>
        /// <remarks>
        /// <para>This parameter has the same function as \<c>AnnotationMissionDebugDataSourceList\\</c>. You can specify either of them. The format is \<c>[1]\\</c>, \<c>[2]\\</c>, or \<c>[1,2]\\</c>. You can specify multiple filter conditions in the array. The enumeration values are as follows:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>1: Outbound call task</para>
        /// </description></item>
        /// <item><description><para>2: Test task</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[1]</para>
        /// </summary>
        [NameInMap("AnnotationMissionDebugDataSourceListJsonString")]
        [Validation(Required=false)]
        public string AnnotationMissionDebugDataSourceListJsonString { get; set; }

        /// <summary>
        /// <para>The name of the annotation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>询问卖车-标注任务-20230506-112934</para>
        /// </summary>
        [NameInMap("AnnotationMissionName")]
        [Validation(Required=false)]
        public string AnnotationMissionName { get; set; }

        /// <summary>
        /// <para>The bot ID.</para>
        /// <remarks>
        /// <para>You can obtain this ID from the \<c>DescribeScript\\</c> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-fqEnFZBYnb</para>
        /// </summary>
        [NameInMap("ChatbotId")]
        [Validation(Required=false)]
        public string ChatbotId { get; set; }

        /// <summary>
        /// <para>The end time for filtering calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1682956800000</para>
        /// </summary>
        [NameInMap("ConversationTimeEndFilter")]
        [Validation(Required=false)]
        public long? ConversationTimeEndFilter { get; set; }

        /// <summary>
        /// <para>The start time for filtering calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683302400000</para>
        /// </summary>
        [NameInMap("ConversationTimeStartFilter")]
        [Validation(Required=false)]
        public long? ConversationTimeStartFilter { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude call records that have been annotated in other tasks. If you do not specify this parameter, the default value is \<c>false\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ExcludeOtherSession")]
        [Validation(Required=false)]
        public bool? ExcludeOtherSession { get; set; }

        /// <summary>
        /// <para>Indicates whether the business process ended normally.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when \<c>SessionEndReasonFilterList\\</c> is not specified.</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>true\\</c>: The call record is normal.</para>
        /// </description></item>
        /// <item><description><para>\<c>false\\</c>: The call did not end normally.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Finished")]
        [Validation(Required=false)]
        public bool? Finished { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bf3b51a5-e88a-4636-98b0-1a34725a085b</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The custom sampling amount.</para>
        /// <remarks>
        /// <para>This parameter is required and takes effect only when \<c>SamplingType\\</c> is set to 3. Otherwise, the task fails to be created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SamplingCount")]
        [Validation(Required=false)]
        public int? SamplingCount { get; set; }

        /// <summary>
        /// <para>The sampling percentage.</para>
        /// <remarks>
        /// <para>This parameter is required and takes effect only when \<c>SamplingType\\</c> is set to 2. Otherwise, the task fails to be created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SamplingRate")]
        [Validation(Required=false)]
        public int? SamplingRate { get; set; }

        /// <summary>
        /// <para>The sampling type.</para>
        /// <list type="bullet">
        /// <item><description><para>1: Full data</para>
        /// </description></item>
        /// <item><description><para>2: Percentage</para>
        /// </description></item>
        /// <item><description><para>3: Custom amount</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SamplingType")]
        [Validation(Required=false)]
        public int? SamplingType { get; set; }

        /// <summary>
        /// <para>The outbound scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6236f21e-2e04-4dad-a47b-ae77e6a48325</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The filter condition for call completion statuses.</para>
        /// <remarks>
        /// <para>This parameter has the same function as \<c>SessionEndReasonFilterListJsonString\\</c>. You can specify either of them.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SessionEndReasonFilterList")]
        [Validation(Required=false)]
        public List<int?> SessionEndReasonFilterList { get; set; }

        /// <summary>
        /// <para>The filter condition for call completion statuses.</para>
        /// <remarks>
        /// <para>This parameter has the same function as \<c>SessionEndReasonFilterList\\</c>. You can specify either of them. The format is \<c>[1]\\</c> or \<c>[1,2]\\</c>. You can specify multiple filter conditions in the array. The enumeration values for the filter conditions are as follows.</para>
        /// </remarks>
        /// <para><b>Enumeration values for filtering call records</b></para>
        /// <list type="bullet">
        /// <item><description><para>1: The call ended normally.</para>
        /// </description></item>
        /// <item><description><para>2: The bot hung up after a recognition failure.</para>
        /// </description></item>
        /// <item><description><para>3: The call was hung up due to a silence timeout.</para>
        /// </description></item>
        /// <item><description><para>4: The user hung up after a recognition failure.</para>
        /// </description></item>
        /// <item><description><para>5: The user hung up for no reason.</para>
        /// </description></item>
        /// <item><description><para>6: The call was transferred to a manual agent after an intent was hit.</para>
        /// </description></item>
        /// <item><description><para>7: The call was transferred to a manual agent after a recognition failure.</para>
        /// </description></item>
        /// <item><description><para>8: No interaction from the user.</para>
        /// </description></item>
        /// <item><description><para>9: The call was interrupted by a system exception.</para>
        /// </description></item>
        /// <item><description><para>10: The call was transferred to an IVR after an intent was hit.</para>
        /// </description></item>
        /// <item><description><para>11: The call was transferred to an IVR after a recognition failure.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[1]</para>
        /// </summary>
        [NameInMap("SessionEndReasonFilterListJsonString")]
        [Validation(Required=false)]
        public string SessionEndReasonFilterListJsonString { get; set; }

    }

}
