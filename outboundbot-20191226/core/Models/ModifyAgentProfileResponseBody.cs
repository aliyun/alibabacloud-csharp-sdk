// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyAgentProfileResponseBody : TeaModel {
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
        public ModifyAgentProfileResponseBodyData Data { get; set; }
        public class ModifyAgentProfileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The agent profile ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3d7d253cfb77476da0cf3681bcf7b4e8</para>
            /// </summary>
            [NameInMap("AgentProfileId")]
            [Validation(Required=false)]
            public string AgentProfileId { get; set; }

            /// <summary>
            /// <para>Agent Template ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-survey</para>
            /// </summary>
            [NameInMap("AgentProfileTemplateId")]
            [Validation(Required=false)]
            public string AgentProfileTemplateId { get; set; }

            /// <summary>
            /// <para>Agent Type</para>
            /// 
            /// <b>Example:</b>
            /// <para>Human</para>
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
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1721356124220</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a large model scenario</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>788066f2-f160-458e-a3bb-83e1c9d5606d</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instruction configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{
            ///     &quot;type&quot;: &quot;TransferToAgent&quot;,
            ///     &quot;instructions&quot;: [{
            ///         &quot;code&quot;: &quot;Transfer0&quot;,
            ///         &quot;skillGroupId&quot;: &quot;testcode&quot;,
            ///         &quot;skillGroupName&quot;: &quot;skillgroup&quot;
            ///     }],
            ///     &quot;timeoutEnable&quot;: false
            /// }, {
            ///     &quot;type&quot;: &quot;CollectNumber&quot;,
            ///     &quot;instructions&quot;: [{
            ///         &quot;code&quot;: &quot;DTMF0&quot;,
            ///         &quot;name&quot;: &quot;Number collection test&quot;,
            ///         &quot;collectVoice&quot;: true,
            ///         &quot;terminator&quot;: &quot;#&quot;
            ///     }]
            /// }]</para>
            /// </summary>
            [NameInMap("InstructionJson")]
            [Validation(Required=false)]
            public string InstructionJson { get; set; }

            /// <summary>
            /// <para>The label description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{
            ///     &quot;name&quot;: &quot;Satisfied&quot;,
            ///     &quot;description&quot;: &quot;Whether interested in the introduced game content&quot;,
            ///     &quot;valueList&quot;: &quot;[\&quot;Interested\&quot;,\&quot;Not interested\&quot;]&quot;
            /// }]</para>
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
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("ModelConfig")]
            [Validation(Required=false)]
            public string ModelConfig { get; set; }

            /// <summary>
            /// <para>The NLU configuration. Parameter settings:</para>
            /// <list type="bullet">
            /// <item><description>chatbotInstanceId: the Chatbot large model robot instance ID.</description></item>
            /// <item><description>faqCategoryIds: the attached FAQ category IDs.</description></item>
            /// <item><description>llmAgentId: the Chatbot large model workspace ID.</description></item>
            /// <item><description>llmAgentKey: the Chatbot large model workspace key.</description></item>
            /// <item><description>llmAgentInstanceId: the Chatbot large model workspace instance ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;chatbotInstanceId&quot;: &quot;chatbot-cn-j7eiVJZRmb&quot;,
            ///     &quot;faqCategoryIds&quot;: [30000474726],
            ///     &quot;llmAgentId&quot;: &quot;1246206&quot;,
            ///     &quot;llmAgentInstanceId&quot;: &quot;outbound_05efb75a-95df-438e-9b9b-8f2c857d5498&quot;,
            ///     &quot;llmAgentKey&quot;: &quot;d682716514814815ae77757c0bcbda01_p_outbound_public&quot;
            /// }</para>
            /// </summary>
            [NameInMap("NluConfigJson")]
            [Validation(Required=false)]
            public string NluConfigJson { get; set; }

            /// <summary>
            /// <para>The prompt in professional mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\nName: Annie \nIdentity: Game Promoter\nBackground: Promote the latest promotional events to players over the phone, ensuring that every player stays informed and enjoys the game.\nSkills: As a game customer service representative, recommend limited-time game promotional events to users, highlight the event benefits, and inform them of the participation process.\nConstraints: You need to remember that you are Annie, from the customer service team of a popular game, focusing on promoting the latest promotional events to players over the phone.\nAs a customer service representative proactively contacting players, you need to choose whether to introduce the event based on the player\&quot;s intention to learn about it.\nMaintain the professionalism of the call while keeping the language approachable to ensure players can easily understand the event content.\nClarify the start and end times of the event to ensure players do not get confused.\nHighlight the key rewards and participation methods to increase players\&quot; interest in participating</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>The agent configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;name&quot;: &quot;Annie&quot;,
            ///     &quot;gender&quot;: &quot;Female&quot;,
            ///     &quot;age&quot;: 20,
            ///     &quot;role&quot;: &quot;Game Promoter&quot;,
            ///     &quot;communicationStyle&quot;: [&quot;Friendly&quot;, &quot;Conversational&quot;, &quot;Lively&quot;],
            ///     &quot;goals&quot;: &quot;Promote the latest promotional events to players over the phone, ensuring that every player stays informed and enjoys the game.&quot;,
            ///     &quot;background&quot;: &quot;Event Introduction\nStarting from ${Start Time} until ${End Time}, we have carefully prepared the \&quot;Limited-Time Treasure Hunt\&quot; promotional event for a week. As long as you log in to the game daily during this period, you can claim a login gift pack containing rare materials, energy potions, and exclusive cosmetic rewards.\n\nEvent Highlights\nThe highlight of this event is that players who log in for 5 cumulative days will receive an extra \&quot;Mystery Chest\&quot;. Opening the chest to obtain a rare pet will add a powerful boost to your battles! Do not miss this excellent opportunity to enhance your strength.\n\nHow to Participate\nAfter logging into the game, find \&quot;Limited-Time Treasure Hunt\&quot; in the event panel and click to claim the corresponding rewards. Remember to log in every day, the rewards wait for no one!&quot;,
            ///     &quot;skills&quot;: &quot;As a game customer service representative, recommend limited-time game promotional events to users, highlight the event benefits, and inform them of the participation process.&quot;,
            ///     &quot;workflow&quot;: &quot;1. Friendly greeting and self-introduction\n- Opening: \&quot;Greetings, honorable adventurer! I am Annie from the game customer service team. I am honored to connect with you today to share an exclusive promotional event that is about to launch, which will definitely make your adventure more exciting!\&quot;\n- Introduce the promotional event only after confirming that the player wants to learn about it.\n2. Promotional event introduction\n3. Highlight event benefits\n4. Explain how to participate and remind\n5. Encourage sharing and feedback\n- Call to action: \&quot;If you think this event is good, feel free to share this good news with your guild mates or game friends. At the same time, we also welcome you to share your experience and suggestions through the in-game feedback system after the event ends.\&quot;\nSkill 6: Politely end the call\n- Closing: \&quot;Well, honorable adventurer, that is the main content of this event. I hope you will return with full rewards from the event, and I wish you invincible in your journey! If you have any questions, feel free to contact our customer service team. Thank you for taking my call, I look forward to serving you again, goodbye!\&quot;&quot;,
            ///     &quot;constraint&quot;: &quot;You need to remember that you are Annie, from the customer service team of a popular game, focusing on promoting the latest promotional events to players over the phone.\nAs a customer service representative proactively contacting players, you need to choose whether to introduce the event based on the player\&quot;s intention to learn about it.\nMaintain the professionalism of the call while keeping the language approachable to ensure players can easily understand the event content.\nClarify the start and end times of the event to ensure players do not get confused.\nHighlight the key rewards and participation methods to increase players\&quot; interest in participating.\nEncourage interaction and feedback among players to promote the activity of the game community.\nMaintain politeness when ending the call to leave a good impression on the player.\nWhen the user asks questions unrelated to the goal or process, politely refuse and guide them back to the target topic.\nFor questions you do not know the answer to, do not reply randomly. You need to politely reply \&quot;I am not sure\&quot; and guide them back to the target topic.&quot;,
            ///     &quot;openingPrompt&quot;: &quot;Greetings, honorable adventurer! I am Annie from the game customer service team. I am honored to connect with you today to share an exclusive promotional event that is about to launch, which will definitely make your adventure more exciting!&quot;,
            ///     &quot;output&quot;: &quot;&quot;,
            ///     &quot;aiHangupOutput&quot;: &quot;&quot;,
            ///     &quot;aiSilenceTimeoutOutput&quot;: &quot;&quot;
            /// }</para>
            /// </summary>
            [NameInMap("PromptJson")]
            [Validation(Required=false)]
            public string PromptJson { get; set; }

            /// <summary>
            /// <para>The scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

            /// <summary>
            /// <para>The scenario ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3eacaec0-64ba-4008-9392-1d419b0d2673</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>Indicates whether the template is a system template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("System")]
            [Validation(Required=false)]
            public bool? System { get; set; }

            /// <summary>
            /// <para>The update time. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715416630.0</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The variable configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{
            ///     &quot;name&quot;: &quot;Start Time&quot;,
            ///     &quot;description&quot;: &quot;Start time&quot;
            /// }, {
            ///     &quot;name&quot;: &quot;End Time&quot;,
            ///     &quot;description&quot;: &quot;End time&quot;
            /// }]</para>
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
