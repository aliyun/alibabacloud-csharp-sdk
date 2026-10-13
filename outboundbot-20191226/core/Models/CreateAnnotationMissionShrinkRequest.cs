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
        /// <para>You can obtain this value from the DescribeInstance operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1168702</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The business space key.</para>
        /// <remarks>
        /// <para>You can obtain this value from the DescribeInstance operation.</para>
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
        /// <item><description>1: outbound call</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AnnotationMissionDataSourceType")]
        [Validation(Required=false)]
        public int? AnnotationMissionDataSourceType { get; set; }

        /// <summary>
        /// <para>The annotation data source list.</para>
        /// <remarks>
        /// <para>This parameter has the same function as AnnotationMissionDebugDataSourceListJsonString. Specify either one of them.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AnnotationMissionDebugDataSourceList")]
        [Validation(Required=false)]
        public string AnnotationMissionDebugDataSourceListShrink { get; set; }

        /// <summary>
        /// <para>The debug data in JSON format.</para>
        /// <remarks>
        /// <para>This parameter has the same function as AnnotationMissionDebugDataSourceList. Specify either one of them. The format is [1], [2], or [1,2]. You can specify multiple filter conditions in the array. The enum values for the filter conditions are as follows.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>1: outbound call task</description></item>
        /// <item><description>2: test task</description></item>
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
        /// <para>CarSaleInquiry-AnnotationTask-20230506-112934</para>
        /// </summary>
        [NameInMap("AnnotationMissionName")]
        [Validation(Required=false)]
        public string AnnotationMissionName { get; set; }

        /// <summary>
        /// <para>The robot ID.</para>
        /// <remarks>
        /// <para>You can obtain this value from the DescribeScript operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-fqEnFZBYnb</para>
        /// </summary>
        [NameInMap("ChatbotId")]
        [Validation(Required=false)]
        public string ChatbotId { get; set; }

        /// <summary>
        /// <para>The end time for the call time filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1682956800000</para>
        /// </summary>
        [NameInMap("ConversationTimeEndFilter")]
        [Validation(Required=false)]
        public long? ConversationTimeEndFilter { get; set; }

        /// <summary>
        /// <para>The start time for the call time filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683302400000</para>
        /// </summary>
        [NameInMap("ConversationTimeStartFilter")]
        [Validation(Required=false)]
        public long? ConversationTimeStartFilter { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude call records that have been annotated by other tasks. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ExcludeOtherSession")]
        [Validation(Required=false)]
        public bool? ExcludeOtherSession { get; set; }

        /// <summary>
        /// <para>Specifies whether the business ended normally.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when SessionEndReasonFilterList is not specified.</para>
        /// <list type="bullet">
        /// <item><description>true: normal call records</description></item>
        /// <item><description>false: abnormal call records</description></item>
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
        /// <para>The custom sampling quantity.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when SamplingType is set to 3. This parameter is required in that case. Otherwise, the creation fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SamplingCount")]
        [Validation(Required=false)]
        public int? SamplingCount { get; set; }

        /// <summary>
        /// <para>The sampling ratio.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when SamplingType is set to 2. This parameter is required in that case. Otherwise, the creation fails.</para>
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
        /// <item><description>1: full</description></item>
        /// <item><description>2: percentage</description></item>
        /// <item><description>3: custom quantity</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SamplingType")]
        [Validation(Required=false)]
        public int? SamplingType { get; set; }

        /// <summary>
        /// <para>The outbound call scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6236f21e-2e04-4dad-a47b-ae77e6a48325</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The call result status filter conditions.</para>
        /// <remarks>
        /// <para>This parameter has the same function as SessionEndReasonFilterListJsonString. Specify either one of them.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SessionEndReasonFilterList")]
        [Validation(Required=false)]
        public List<int?> SessionEndReasonFilterList { get; set; }

        /// <summary>
        /// <para>The call result status filter conditions.</para>
        /// <remarks>
        /// <para>This parameter has the same function as SessionEndReasonFilterList. Specify either one of them. The format is [1], [1,2], etc. You can specify multiple filter conditions in the array. The enum values for the filter conditions are as follows.</para>
        /// </remarks>
        /// <para><b>Call record filter enum values</b></para>
        /// <list type="bullet">
        /// <item><description>1: normal completion</description></item>
        /// <item><description>2: robot hung up after recognition rejection</description></item>
        /// <item><description>3: hung up due to silence timeout</description></item>
        /// <item><description>4: user hung up after recognition rejection</description></item>
        /// <item><description>5: user hung up without reason</description></item>
        /// <item><description>6: transferred to agent by intent match</description></item>
        /// <item><description>7: transferred to agent by recognition rejection</description></item>
        /// <item><description>8: no interaction on user side</description></item>
        /// <item><description>9: system exception interruption</description></item>
        /// <item><description>10: transferred to IVR by intent match</description></item>
        /// <item><description>11: transferred to IVR by recognition rejection</description></item>
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
