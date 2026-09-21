// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ChatRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID used for the service. This parameter is optional. You can specify an agent generated after DAS Agent is enabled or an agent that you manually created. If this parameter is not specified, the default agent is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag-472T0DxtmjIxxxxx</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;id&quot;:&quot;68fe0321-37fe-4c75-a118-b61b33156f6a&quot;,&quot;role&quot;:&quot;user&quot;,&quot;content&quot;:[{&quot;type&quot;:&quot;text&quot;,&quot;text&quot;:&quot;hello&quot;}]}</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The user interaction feedback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;metadata&quot;:{&quot;a2uiClientDataModel&quot;:{&quot;decided&quot;:true,&quot;interaction&quot;:{&quot;request&quot;:{&quot;allowFreeText&quot;:true,&quot;question&quot;:&quot;question?&quot;,&quot;options&quot;:[{&quot;label&quot;:&quot;162&quot;,&quot;value&quot;:&quot;162&quot;},{&quot;label&quot;:&quot;242&quot;,&quot;value&quot;:&quot;242&quot;},{&quot;label&quot;:&quot;243&quot;,&quot;value&quot;:&quot;243&quot;},{&quot;label&quot;:&quot;486&quot;,&quot;value&quot;:&quot;486&quot;}]},&quot;kind&quot;:&quot;choice&quot;,&quot;interruptId&quot;:&quot;5857955e-4856-4ab3-969e-f8b4c484bda4&quot;,&quot;status&quot;:&quot;pending&quot;},&quot;free_text&quot;:&quot;&quot;},&quot;a2uiAction&quot;:{&quot;name&quot;:&quot;das_interaction_response&quot;,&quot;context&quot;:{&quot;value&quot;:&quot;162&quot;},&quot;surfaceId&quot;:&quot;render-choice-7c03eb4f927f42ff8c30b30a2cc0797d&quot;,&quot;sourceComponentId&quot;:&quot;opts-0&quot;,&quot;timestamp&quot;:&quot;2026-09-15T06:54:15.556Z&quot;}},&quot;payload&quot;:{&quot;value&quot;:&quot;162&quot;},&quot;interruptId&quot;:&quot;5857955e-4856-4ab3-969e-f8b4c484bda4&quot;,&quot;status&quot;:&quot;resolved&quot;}]</para>
        /// </summary>
        [NameInMap("Resume")]
        [Validation(Required=false)]
        public string Resume { get; set; }

        /// <summary>
        /// <para>The session ID in UUID string format. This parameter is optional. If this parameter is not specified, a new session is created by default. To maintain context across conversations, use the same session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to output summary information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

    }

}
