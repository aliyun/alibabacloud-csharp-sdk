// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyDialogueFlowResponseBody : TeaModel {
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
        /// <para>The JSON string that defines the dialogue flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;transitions&quot;:[{&quot;id&quot;:&quot;a91c4023&quot;,&quot;index&quot;:1,&quot;source&quot;:&quot;cc31e02b&quot;,&quot;sourceAnchor&quot;:0,&quot;target&quot;:&quot;946045be&quot;,&quot;targetAnchor&quot;:0}],&quot;nodes&quot;:[{&quot;collectedNumberEnabled&quot;:false,&quot;content&quot;:{&quot;branches&quot;:[{&quot;branchId&quot;:&quot;f5450420-09ab-11ea-b107-e9059c6a79d8&quot;,&quot;branchName&quot;:&quot;发起对话&quot;}]},&quot;coordinates&quot;:{&quot;x&quot;:180,&quot;y&quot;:134},&quot;id&quot;:&quot;cc31e02b&quot;,&quot;index&quot;:0,&quot;interruptible&quot;:false,&quot;nodeIndex&quot;:0,&quot;shape&quot;:&quot;start-html&quot;,&quot;size&quot;:&quot;170<em>34&quot;,&quot;type&quot;:&quot;start&quot;,&quot;x&quot;:180,&quot;y&quot;:134},{&quot;collectedNumberEnabled&quot;:false,&quot;content&quot;:{&quot;actionParams&quot;:&quot;&quot;,&quot;action&quot;:&quot;Hangup&quot;},&quot;coordinates&quot;:{&quot;x&quot;:487.65625,&quot;y&quot;:155},&quot;id&quot;:&quot;946045be&quot;,&quot;index&quot;:2,&quot;interruptible&quot;:false,&quot;labels&quot;:[],&quot;name&quot;:&quot;功能节点&quot;,&quot;nodeIndex&quot;:1,&quot;questions&quot;:[&quot;好的同学，您的情况已了解了，稍后我们会安排资深顾问老师给您做更详细的留学评估以及升学指导，请留意电话接听&quot;],&quot;script&quot;:&quot;好的同学，您的情况已了解了，稍后我们会安排资深顾问老师给您做更详细的留学评估以及升学指导，请留意电话接听&quot;,&quot;shape&quot;:&quot;function-html&quot;,&quot;size&quot;:&quot;170</em>34&quot;,&quot;type&quot;:&quot;transfer&quot;,&quot;x&quot;:500,&quot;y&quot;:182}]}</para>
        /// </summary>
        [NameInMap("DialogueFlowDefinition")]
        [Validation(Required=false)]
        public string DialogueFlowDefinition { get; set; }

        /// <summary>
        /// <para>The dialogue flow ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>390515b5-6115-4ccf-83e2-52d5bfaf2ddf</para>
        /// </summary>
        [NameInMap("DialogueFlowId")]
        [Validation(Required=false)]
        public string DialogueFlowId { get; set; }

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
        /// <para>Succcess</para>
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
