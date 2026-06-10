// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetAgentProfileResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAgentProfileResponseBodyData Data { get; set; }
        public class GetAgentProfileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the agent configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d31794e2a51f47d2901b4094d88311d7</para>
            /// </summary>
            [NameInMap("AgentProfileId")]
            [Validation(Required=false)]
            public string AgentProfileId { get; set; }

            /// <summary>
            /// <para>The ID of the agent configuration template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-survey</para>
            /// </summary>
            [NameInMap("AgentProfileTemplateId")]
            [Validation(Required=false)]
            public string AgentProfileTemplateId { get; set; }

            /// <summary>
            /// <para>The agent type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <para>The API plugin configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("ApiPluginJson")]
            [Validation(Required=false)]
            public string ApiPluginJson { get; set; }

            /// <summary>
            /// <para>The time when the configuration was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741338619000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一个大模型机器人</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7f04f92c-ccfc-4f8f-a816-6902023be5c6</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instruction configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;type&quot;:&quot;TransferToAgent&quot;,&quot;instructions&quot;:[{&quot;code&quot;:&quot;Transfer0&quot;,&quot;skillGroupId&quot;:&quot;123&quot;,&quot;skillGroupName&quot;:&quot;123&quot;}],&quot;timeoutEnable&quot;:false},{&quot;type&quot;:&quot;CollectNumber&quot;,&quot;instructions&quot;:[]}]</para>
            /// </summary>
            [NameInMap("InstructionJson")]
            [Validation(Required=false)]
            public string InstructionJson { get; set; }

            /// <summary>
            /// <para>The description of the labels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;name\&quot;:\&quot;是否送达\&quot;,\&quot;description\&quot;:\&quot;购买的家电是否已经送达\&quot;,\&quot;valueList\&quot;:\&quot;[\\\&quot;是\\\&quot;,\\\&quot;否\\\&quot;]\&quot;},{\&quot;name\&quot;:\&quot;预约上门时间\&quot;,\&quot;description\&quot;:\&quot;收集客户期望的上门安装时间\&quot;,\&quot;valueList\&quot;:\&quot;[]\&quot;}]</para>
            /// </summary>
            [NameInMap("LabelsJson")]
            [Validation(Required=false)]
            public string LabelsJson { get; set; }

            /// <summary>
            /// <para>The model ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model_002</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The model configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ModelConfig")]
            [Validation(Required=false)]
            public string ModelConfig { get; set; }

            /// <summary>
            /// <para>The Natural Language Understanding (NLU) configuration. The parameters are described as follows:</para>
            /// <list type="bullet">
            /// <item><description><para>chatbotInstanceId: The instance ID of the ChatMe LLM agent.</para>
            /// </description></item>
            /// <item><description><para>faqCategoryIds: The IDs of the attached FAQ categories.</para>
            /// </description></item>
            /// <item><description><para>llmAgentId: The ID of the ChatMe LLM workspace.</para>
            /// </description></item>
            /// <item><description><para>llmAgentKey: The key of the ChatMe LLM workspace.</para>
            /// </description></item>
            /// <item><description><para>llmAgentInstanceId: The instance ID of the ChatMe LLM workspace.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;chatbotInstanceId&quot;:&quot;chatbot-cn-j7eiVJZRmb&quot;,&quot;faqCategoryIds&quot;:[30000474726],&quot;llmAgentId&quot;:&quot;1246206&quot;,&quot;llmAgentInstanceId&quot;:&quot;outbound_05efb75a-95df-438e-9b9b-8f2c857d5498&quot;,&quot;llmAgentKey&quot;:&quot;d682716514814815ae77757c0bcbda01_p_outbound_public&quot;}</para>
            /// </summary>
            [NameInMap("NluConfigJson")]
            [Validation(Required=false)]
            public string NluConfigJson { get; set; }

            /// <summary>
            /// <para>The prompt for the professional pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>The agent configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;name&quot;:&quot;小x&quot;,&quot;gender&quot;:&quot;男&quot;,&quot;age&quot;:18,&quot;role&quot;:&quot;游戏推广员&quot;,&quot;communicationStyle&quot;:[&quot;亲切&quot;],&quot;goals&quot;:&quot;你好&quot;,&quot;background&quot;:&quot;不是很好&quot;,&quot;openingPrompt&quot;:&quot;你好，我是xxx&quot;}</para>
            /// </summary>
            [NameInMap("PromptJson")]
            [Validation(Required=false)]
            public string PromptJson { get; set; }

            /// <summary>
            /// <para>The scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试场景</para>
            /// </summary>
            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

            /// <summary>
            /// <para>The scenario ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d13ad2d3-3fe6-4352-b38b-bd6559047de8</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>Indicates whether the template is a system template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("System")]
            [Validation(Required=false)]
            public bool? System { get; set; }

            /// <summary>
            /// <para>The time when the configuration was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741338619000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The variable configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;name\&quot;:\&quot;name\&quot;,\&quot;description\&quot;:\&quot;客户姓名\&quot;},{\&quot;name\&quot;:\&quot;gender\&quot;,\&quot;description\&quot;:\&quot;客户性别\&quot;}]</para>
            /// </summary>
            [NameInMap("VariablesJson")]
            [Validation(Required=false)]
            public string VariablesJson { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A573837-3AD3-54CF-930A-07A3287042C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
