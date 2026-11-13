// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListCustomScriptTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
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
        public ListCustomScriptTemplatesResponseBodyData Data { get; set; }
        public class ListCustomScriptTemplatesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of custom scenario templates.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCustomScriptTemplatesResponseBodyDataList> List { get; set; }
            public class ListCustomScriptTemplatesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The ID of the custom scenario template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d31794e2a51f47d2901b4094d88311d7</para>
                /// </summary>
                [NameInMap("AgentProfileId")]
                [Validation(Required=false)]
                public string AgentProfileId { get; set; }

                /// <summary>
                /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1741338619000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the custom scenario template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a large language model bot</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The instance ID to which the template belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e49ad122-15a1-443a-a102-84a78a93be79</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The label description. The value is a string in JSON array format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;name\&quot;:\&quot;Delivered\&quot;,\&quot;description\&quot;:\&quot;Whether the purchased home appliance has been delivered\&quot;,\&quot;valueList\&quot;:\&quot;[\\\&quot;Yes\\\&quot;,\\\&quot;No\\\&quot;]\&quot;},{\&quot;name\&quot;:\&quot;On-site service appointment time\&quot;,\&quot;description\&quot;:\&quot;Collect the customer\&quot;s expected on-site installation time\&quot;,\&quot;valueList\&quot;:\&quot;[]\&quot;}]</para>
                /// </summary>
                [NameInMap("LabelsJson")]
                [Validation(Required=false)]
                public string LabelsJson { get; set; }

                /// <summary>
                /// <para>The ID of the model used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>model_002</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The name of the custom scenario template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test scenario</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The prompt in professional mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>\nName: Annie \nRole: Game Promoter\nBackground: Promote the latest benefit activities to players over the phone to ensure that every player can get the information in time and enjoy the game.\nSkills: As a game customer service representative, recommend limited-time game benefit activities to users, highlight the benefits, and inform them of the participation process.\nConstraints: You need to remember that you are Annie,</para>
                /// </summary>
                [NameInMap("Prompt")]
                [Validation(Required=false)]
                public string Prompt { get; set; }

                /// <summary>
                /// <para>The agent configuration. The value is a string in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;name&quot;:&quot;Xiao X&quot;,&quot;gender&quot;:&quot;Male&quot;,&quot;age&quot;:18,&quot;role&quot;:&quot;Game Promoter&quot;,&quot;communicationStyle&quot;:[&quot;Friendly&quot;],&quot;goals&quot;:&quot;Hello&quot;,&quot;background&quot;:&quot;Not very good&quot;,&quot;openingPrompt&quot;:&quot;Hello, I am xxx&quot;}</para>
                /// </summary>
                [NameInMap("PromptJson")]
                [Validation(Required=false)]
                public string PromptJson { get; set; }

                /// <summary>
                /// <para>The ID of the scenario associated with the custom scenario template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43972417-0657-452a-81c2-c59d8245a9b2</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of custom scenario templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>Not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Not used</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The message returned by the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Not used</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
