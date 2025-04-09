// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyAgentProfileResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyAgentProfileResponseBodyData Data { get; set; }
        public class ModifyAgentProfileResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3d7d253cfb77476da0cf3681bcf7b4e8</para>
            /// </summary>
            [NameInMap("AgentProfileId")]
            [Validation(Required=false)]
            public string AgentProfileId { get; set; }

            /// <summary>
            /// <para>agent template id</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-survey</para>
            /// </summary>
            [NameInMap("AgentProfileTemplateId")]
            [Validation(Required=false)]
            public string AgentProfileTemplateId { get; set; }

            /// <summary>
            /// <para>agent type</para>
            /// 
            /// <b>Example:</b>
            /// <para>Human</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("ApiPluginJson")]
            [Validation(Required=false)]
            public string ApiPluginJson { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1721356124220</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>788066f2-f160-458e-a3bb-83e1c9d5606d</para>
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
            /// <para>model_002</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;chatbotInstanceId&quot;:&quot;chatbot-cn-j7eiVJZRmb&quot;,&quot;faqCategoryIds&quot;:[30000474726],&quot;llmAgentId&quot;:&quot;1246206&quot;,&quot;llmAgentInstanceId&quot;:&quot;outbound_05efb75a-95df-438e-9b9b-8f2c857d5498&quot;,&quot;llmAgentKey&quot;:&quot;d682716514814815ae77757c0bcbda01_p_outbound_public&quot;}</para>
            /// </summary>
            [NameInMap("NluConfigJson")]
            [Validation(Required=false)]
            public string NluConfigJson { get; set; }

            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            [NameInMap("PromptJson")]
            [Validation(Required=false)]
            public string PromptJson { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3eacaec0-64ba-4008-9392-1d419b0d2673</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("System")]
            [Validation(Required=false)]
            public bool? System { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1715416630.0</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("VariablesJson")]
            [Validation(Required=false)]
            public string VariablesJson { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
