// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateCustomScriptTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The description of the custom scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a large language model bot</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ec0c897-b92c-40e4-9ad7-e6e4f5ce13bb</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The label descriptions in JSON array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;Delivered\&quot;,\&quot;description\&quot;:\&quot;Whether the purchased home appliance has been delivered\&quot;,\&quot;valueList\&quot;:\&quot;[\\\&quot;Yes\\\&quot;,\\\&quot;No\\\&quot;]\&quot;},{\&quot;name\&quot;:\&quot;Appointment Time\&quot;,\&quot;description\&quot;:\&quot;Collect the customer\&quot;s expected on-site installation time\&quot;,\&quot;valueList\&quot;:\&quot;[]\&quot;}]</para>
        /// </summary>
        [NameInMap("LabelsJson")]
        [Validation(Required=false)]
        public string LabelsJson { get; set; }

        /// <summary>
        /// <para>The ID of the model used to create the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model_002</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The name of the custom scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test scenario</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The prompt for professional mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>\nName: Annie \nIdentity: Game Promoter\nBackground: Promote the latest welfare activities to players over the phone to ensure that every player can get the information in time and enjoy the game.\nSkills: As a game customer service representative, recommend time-limited game welfare activities to users, highlight the benefits, and inform them of the participation process.\nConstraints: You need to remember that you are Annie,</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The agent configuration in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Xiao X&quot;,&quot;gender&quot;:&quot;Male&quot;,&quot;age&quot;:18,&quot;role&quot;:&quot;Game Promoter&quot;,&quot;communicationStyle&quot;:[&quot;Friendly&quot;],&quot;goals&quot;:&quot;Hello&quot;,&quot;background&quot;:&quot;Not very good&quot;,&quot;openingPrompt&quot;:&quot;Hello, I am XXX&quot;}</para>
        /// </summary>
        [NameInMap("PromptJson")]
        [Validation(Required=false)]
        public string PromptJson { get; set; }

        /// <summary>
        /// <para>The script ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43972417-0657-452a-81c2-c59d8245a9b2</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

    }

}
