// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateAgentProfileRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-survey</para>
        /// </summary>
        [NameInMap("AgentProfileTemplateId")]
        [Validation(Required=false)]
        public string AgentProfileTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("AppIp")]
        [Validation(Required=false)]
        public string AppIp { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[30000474726]</para>
        /// </summary>
        [NameInMap("FaqCategoryIds")]
        [Validation(Required=false)]
        public string FaqCategoryIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;type\&quot;:\&quot;TransferToAgent\&quot;,\&quot;instructions\&quot;:[{\&quot;code\&quot;:\&quot;Transfer0\&quot;,\&quot;skillGroupId\&quot;:\&quot;123\&quot;,\&quot;skillGroupName\&quot;:\&quot;123\&quot;}]</para>
        /// </summary>
        [NameInMap("InstructionJson")]
        [Validation(Required=false)]
        public string InstructionJson { get; set; }

        [NameInMap("LabelsJson")]
        [Validation(Required=false)]
        public string LabelsJson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model_001</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ModelConfig")]
        [Validation(Required=false)]
        public string ModelConfig { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("PromptJson")]
        [Validation(Required=false)]
        public string PromptJson { get; set; }

        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aa279896-64a6-4182-864c-4f2b04ec8d17</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        [NameInMap("VariablesJson")]
        [Validation(Required=false)]
        public string VariablesJson { get; set; }

    }

}
