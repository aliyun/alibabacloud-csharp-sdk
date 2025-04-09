// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateAnnotationMissionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1168702</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9137ab9c27044921860030adf8590ec4_p_outbound_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AnnotationMissionDataSourceType")]
        [Validation(Required=false)]
        public int? AnnotationMissionDataSourceType { get; set; }

        [NameInMap("AnnotationMissionDebugDataSourceList")]
        [Validation(Required=false)]
        public List<int?> AnnotationMissionDebugDataSourceList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[1]</para>
        /// </summary>
        [NameInMap("AnnotationMissionDebugDataSourceListJsonString")]
        [Validation(Required=false)]
        public string AnnotationMissionDebugDataSourceListJsonString { get; set; }

        [NameInMap("AnnotationMissionName")]
        [Validation(Required=false)]
        public string AnnotationMissionName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>chatbot-cn-fqEnFZBYnb</para>
        /// </summary>
        [NameInMap("ChatbotId")]
        [Validation(Required=false)]
        public string ChatbotId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1682956800000</para>
        /// </summary>
        [NameInMap("ConversationTimeEndFilter")]
        [Validation(Required=false)]
        public long? ConversationTimeEndFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1683302400000</para>
        /// </summary>
        [NameInMap("ConversationTimeStartFilter")]
        [Validation(Required=false)]
        public long? ConversationTimeStartFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ExcludeOtherSession")]
        [Validation(Required=false)]
        public bool? ExcludeOtherSession { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Finished")]
        [Validation(Required=false)]
        public bool? Finished { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bf3b51a5-e88a-4636-98b0-1a34725a085b</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SamplingCount")]
        [Validation(Required=false)]
        public int? SamplingCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SamplingRate")]
        [Validation(Required=false)]
        public int? SamplingRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SamplingType")]
        [Validation(Required=false)]
        public int? SamplingType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6236f21e-2e04-4dad-a47b-ae77e6a48325</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        [NameInMap("SessionEndReasonFilterList")]
        [Validation(Required=false)]
        public List<int?> SessionEndReasonFilterList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[1]</para>
        /// </summary>
        [NameInMap("SessionEndReasonFilterListJsonString")]
        [Validation(Required=false)]
        public string SessionEndReasonFilterListJsonString { get; set; }

    }

}
