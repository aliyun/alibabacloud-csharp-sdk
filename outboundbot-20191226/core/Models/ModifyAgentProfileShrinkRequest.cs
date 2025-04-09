// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyAgentProfileShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37ca3ca1ac4b4e57adf3da5b5d939d04</para>
        /// </summary>
        [NameInMap("AgentProfileId")]
        [Validation(Required=false)]
        public string AgentProfileId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("ApiPluginJson")]
        [Validation(Required=false)]
        public string ApiPluginJson { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FaqCategoryIds")]
        [Validation(Required=false)]
        public string FaqCategoryIdsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174952ab-9825-4cc9-a5e2-de82d7fa4cdd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;TransferToAgent&quot;,&quot;instructions&quot;:[{&quot;code&quot;:&quot;Transfer0&quot;,&quot;skillGroupId&quot;:&quot;123&quot;,&quot;skillGroupName&quot;:&quot;123&quot;}],&quot;timeoutEnable&quot;:false},{&quot;type&quot;:&quot;CollectNumber&quot;,&quot;instructions&quot;:[]}]</para>
        /// </summary>
        [NameInMap("InstructionJson")]
        [Validation(Required=false)]
        public string InstructionJson { get; set; }

        [NameInMap("LabelsJson")]
        [Validation(Required=false)]
        public string LabelsJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>model_001</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
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

        [NameInMap("VariablesJson")]
        [Validation(Required=false)]
        public string VariablesJson { get; set; }

    }

}
