// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyAgentProfileShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The agent profile ID.</para>
        /// <remarks>
        /// <para>You can obtain the agent profile ID of a created scenario from the ChatbotId response parameter of DescribeScript.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37ca3ca1ac4b4e57adf3da5b5d939d04</para>
        /// </summary>
        [NameInMap("AgentProfileId")]
        [Validation(Required=false)]
        public string AgentProfileId { get; set; }

        /// <summary>
        /// <para>The API plugin configuration.</para>
        /// <remarks>
        /// <para>To bind multiple APIs, obtain the UUIDs of multiple APIs through ListApiPlugins, and fill them in the format of [{&quot;uuid&quot;:&quot;xxx&quot;},{&quot;uuid&quot;:&quot;xxxx&quot;},....].</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;uuid&quot;:&quot;a55d171da96c41a************&quot;},{&quot;uuid&quot;:&quot;d41a3e5195d1402********&quot;}]</para>
        /// </summary>
        [NameInMap("ApiPluginJson")]
        [Validation(Required=false)]
        public string ApiPluginJson { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>First version submitted for review</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The FAQ category IDs.</para>
        /// </summary>
        [NameInMap("FaqCategoryIds")]
        [Validation(Required=false)]
        public string FaqCategoryIdsShrink { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174952ab-9825-4cc9-a5e2-de82d7fa4cdd</para>
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
        /// <para>model_001</para>
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
        /// <para>Test scenario</para>
        /// </summary>
        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

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

}
