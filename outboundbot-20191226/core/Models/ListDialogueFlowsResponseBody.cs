// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListDialogueFlowsResponseBody : TeaModel {
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
        /// <para>A list of dialogue flows.</para>
        /// </summary>
        [NameInMap("DialogueFlows")]
        [Validation(Required=false)]
        public List<ListDialogueFlowsResponseBodyDialogueFlows> DialogueFlows { get; set; }
        public class ListDialogueFlowsResponseBodyDialogueFlows : TeaModel {
            /// <summary>
            /// <para>The dialogue flow data, formatted as a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;transitions&quot;:[{&quot;source&quot;:&quot;cc31e02b&quot;,&quot;sourceAnchor&quot;:0,&quot;target&quot;:&quot;345700de&quot;,&quot;targetAnchor&quot;:0,&quot;id&quot;:&quot;16d37c6e&quot;,&quot;index&quot;:1}],&quot;nodes&quot;:[{&quot;shape&quot;:&quot;start-html&quot;,&quot;type&quot;:&quot;start&quot;,&quot;size&quot;:&quot;170<em>34&quot;,&quot;x&quot;:180,&quot;y&quot;:134,&quot;id&quot;:&quot;cc31e02b&quot;,&quot;index&quot;:0,&quot;nodeIndex&quot;:0,&quot;content&quot;:{&quot;branches&quot;:[{&quot;branchName&quot;:&quot;发起对话&quot;,&quot;branchId&quot;:&quot;3c50a880-a7bc-11e9-80fc-5917e4f31864&quot;}]},&quot;coordinates&quot;:{&quot;x&quot;:180,&quot;y&quot;:134}},{&quot;shape&quot;:&quot;function-html&quot;,&quot;type&quot;:&quot;transfer&quot;,&quot;size&quot;:&quot;170</em>34&quot;,&quot;x&quot;:606,&quot;y&quot;:134,&quot;id&quot;:&quot;345700de&quot;,&quot;nodeIndex&quot;:1,&quot;name&quot;:&quot;功能节点&quot;,&quot;script&quot;:&quot;你是 @name ma&quot;,&quot;content&quot;:{&quot;action&quot;:&quot;Hangup&quot;,&quot;actionParams&quot;:&quot;&quot;,&quot;label&quot;:[&quot;test1&quot;,&quot;test2&quot;,&quot;test3&quot;,&quot;test4&quot;,&quot;test5&quot;]},&quot;coordinates&quot;:{&quot;x&quot;:606,&quot;y&quot;:134},&quot;index&quot;:2,&quot;questions&quot;:[&quot;你是 @联系人姓名 ma&quot;]}]}</para>
            /// </summary>
            [NameInMap("DialogueFlowDefinition")]
            [Validation(Required=false)]
            public string DialogueFlowDefinition { get; set; }

            /// <summary>
            /// <para>The dialogue flow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dae01529-3c3e-458e-b07a-97643d09ebb9</para>
            /// </summary>
            [NameInMap("DialogueFlowId")]
            [Validation(Required=false)]
            public string DialogueFlowId { get; set; }

            /// <summary>
            /// <para>The dialogue flow name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>主流程</para>
            /// </summary>
            [NameInMap("DialogueFlowName")]
            [Validation(Required=false)]
            public string DialogueFlowName { get; set; }

            /// <summary>
            /// <para>The flow type.</para>
            /// <list type="bullet">
            /// <item><description><para><c>SubFlow</c>: The subflow.</para>
            /// </description></item>
            /// <item><description><para><c>MainFlow</c>: The main flow.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MainFlow</para>
            /// </summary>
            [NameInMap("DialogueFlowType")]
            [Validation(Required=false)]
            public string DialogueFlowType { get; set; }

            /// <summary>
            /// <para>The outbound script ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2d5aa451-661f-4f08-b0c4-28eec78decc4</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>The script version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1569220563549</para>
            /// </summary>
            [NameInMap("ScriptVersion")]
            [Validation(Required=false)]
            public string ScriptVersion { get; set; }

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
        /// <para>The response message.</para>
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
        /// <para>Indicates whether the request succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
