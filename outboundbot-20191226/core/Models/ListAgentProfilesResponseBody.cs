// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListAgentProfilesResponseBody : TeaModel {
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
        public List<ListAgentProfilesResponseBodyData> Data { get; set; }
        public class ListAgentProfilesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the agent configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37ca3ca1ac4b4e57adf3da5b5d939d04</para>
            /// </summary>
            [NameInMap("AgentProfileId")]
            [Validation(Required=false)]
            public string AgentProfileId { get; set; }

            /// <summary>
            /// <para>The ID of the agent template.</para>
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
            /// <para>“”</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <para>The time when the configuration was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1721701525327</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一个充满智慧的智能体。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e49ad122-15a1-443a-a102-84a78a93be79</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instruction configuration in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;type&quot;:&quot;TransferToAgent&quot;,&quot;instructions&quot;:[{&quot;code&quot;:&quot;Transfer0&quot;,&quot;skillGroupId&quot;:&quot;123&quot;,&quot;skillGroupName&quot;:&quot;123&quot;}],&quot;timeoutEnable&quot;:false},{&quot;type&quot;:&quot;CollectNumber&quot;,&quot;instructions&quot;:[]}]</para>
            /// </summary>
            [NameInMap("InstructionJson")]
            [Validation(Required=false)]
            public string InstructionJson { get; set; }

            /// <summary>
            /// <para>The label definitions in JSON format.</para>
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
            /// <para>The prompt for the professional pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
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
            /// <para>43972417-0657-452a-81c2-c59d8245a9b2</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>Indicates whether this is a system template.</para>
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
            /// <para>1721701525327</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The variable configuration in JSON format.</para>
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
        /// <para>The message returned for the request.</para>
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
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
