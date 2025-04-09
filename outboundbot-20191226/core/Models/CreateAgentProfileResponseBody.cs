// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateAgentProfileResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAgentProfileResponseBodyData Data { get; set; }
        public class CreateAgentProfileResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>37ca3ca1ac4b4e57adf3da5b5d939d04</para>
            /// </summary>
            [NameInMap("AgentProfileId")]
            [Validation(Required=false)]
            public string AgentProfileId { get; set; }

            /// <summary>
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
            /// <para>“”</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1739333534000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1e16c663-0339-4064-9d57-07f772e78f21</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>prompt</para>
            /// </summary>
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
            /// <b>Example:</b>
            /// <para>d13ad2d3-3fe6-4352-b38b-bd6559047de8</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("System")]
            [Validation(Required=false)]
            public bool? System { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1737077564000</para>
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
