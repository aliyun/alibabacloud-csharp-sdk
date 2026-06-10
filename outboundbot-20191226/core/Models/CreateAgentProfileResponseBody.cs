// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateAgentProfileResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAgentProfileResponseBodyData Data { get; set; }
        public class CreateAgentProfileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Agent profile ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>d31794e2a51f47d2901b4094d88311d7</para>
            /// </summary>
            [NameInMap("AgentProfileId")]
            [Validation(Required=false)]
            public string AgentProfileId { get; set; }

            /// <summary>
            /// <para>Agent profile template ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-survey</para>
            /// </summary>
            [NameInMap("AgentProfileTemplateId")]
            [Validation(Required=false)]
            public string AgentProfileTemplateId { get; set; }

            /// <summary>
            /// <para>Agent type</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1739333534000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一个智能体。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1e16c663-0339-4064-9d57-07f772e78f21</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Instruction configuration</para>
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
            ///         &quot;name&quot;: &quot;收号测试&quot;,
            ///         &quot;collectVoice&quot;: true,
            ///         &quot;terminator&quot;: &quot;#&quot;
            ///     }]
            /// }]</para>
            /// </summary>
            [NameInMap("InstructionJson")]
            [Validation(Required=false)]
            public string InstructionJson { get; set; }

            /// <summary>
            /// <para>Label description</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{
            ///     &quot;name&quot;: &quot;是否满意&quot;,
            ///     &quot;description&quot;: &quot;对介绍的游戏内容是否感兴趣&quot;,
            ///     &quot;valueList&quot;: &quot;[\&quot;有兴趣\&quot;,\&quot;没兴趣\&quot;]&quot;
            /// }]</para>
            /// </summary>
            [NameInMap("LabelsJson")]
            [Validation(Required=false)]
            public string LabelsJson { get; set; }

            /// <summary>
            /// <para>Model ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>model_001</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>Model configuration</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("ModelConfig")]
            [Validation(Required=false)]
            public string ModelConfig { get; set; }

            /// <summary>
            /// <para>Prompt (professional mode)</para>
            /// 
            /// <b>Example:</b>
            /// <para>\n名称：安妮 \n身份：游戏推广员\n背景：通过电话向玩家宣传最新福利活动，确保每一位玩家都能及时掌握信息，享受游戏的乐趣。\n技能：作为游戏客服，向用户推荐限时游戏福利活动，强调福利亮点并告知参与流程。\n约束条件：你需要记住你是安妮，来自于热门游戏客服团队，专注于通过电话向玩家宣传最新福利活动。\n作为主动联系玩家的客服，需要根据玩家是否想了解活动的意图来选择是否介绍。\n保持通话的专业性，同时语言平易近人，确保玩家轻松理解活动内容。\n明确活动的起止时间，确保玩家不会混淆。\n强调活动的重点奖励和参与方式，提升玩家的参与兴趣。</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>Agent configuration</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;name&quot;: &quot;安妮&quot;,
            ///     &quot;gender&quot;: &quot;女&quot;,
            ///     &quot;age&quot;: 20,
            ///     &quot;role&quot;: &quot;游戏推广员&quot;,
            ///     &quot;communicationStyle&quot;: [&quot;亲切&quot;, &quot;口语化&quot;, &quot;活泼&quot;],
            ///     &quot;goals&quot;: &quot;通过电话向玩家宣传最新福利活动，确保每一位玩家都能及时掌握信息，享受游戏的乐趣。&quot;,
            ///     &quot;background&quot;: &quot;福利介绍\n从${开始时间}开始，直至${结束时间}结束，为期一周的时间里，我们精心准备了\&quot;限时寻宝\&quot;福利活动。只要您在这段时间内每日登录游戏，即可领取登录礼包，内含珍稀材料、能量药剂和限定外观奖励\n\n福利亮点\n本次活动的亮点在于，累积登录达到5天的玩家，将额外获得一份\&quot;神秘宝箱\&quot;，开启宝箱获得稀有宠物，将为您的战斗增添强大助力！千万别错过这次增强实力的绝佳机会。\n\n参与方式\n登录游戏后，在活动面板中找到\&quot;限时寻宝\&quot;，点击即可领取对应的奖励。记得每天上线，奖励不等人哦！&quot;,
            ///     &quot;skills&quot;: &quot;作为游戏客服，向用户推荐限时游戏福利活动，强调福利亮点并告知参与流程。&quot;,
            ///     &quot;workflow&quot;: &quot;1.亲切问候与自我介绍\n- 开场白：“尊敬的冒险者，您好！我是安妮，来自游戏客服团队。今天有幸与您连线，是想分享一项即将启动的独家福利活动，绝对会让您的探险之旅更加精彩纷呈！”\n- 确认玩家想了解活动后，再进行福利活动的介绍\n2.福利活动介绍\n3.强调福利亮点\n4.说明参与方式与提醒\n5.鼓励分享与反馈\n- 互动号召：“如果您觉得这个活动不错，不妨和您的公会伙伴或者游戏朋友分享这个好消息。同时，我们也非常欢迎您在活动结束后，通过游戏内置的反馈系统告诉我们您的体验感受和建议。”\n技能6: 礼貌结束通话\n- 结束语：“好了，尊敬的冒险者，以上就是这次活动的主要内容。希望您能在活动中满载而归，祝您在旅程中所向披靡！如果还有任何疑问，欢迎随时联系我们客服团队。感谢您的接听，期待再次为您服务，再见！”&quot;,
            ///     &quot;constraint&quot;: &quot;你需要记住你是安妮，来自于热门游戏客服团队，专注于通过电话向玩家宣传最新福利活动。\n作为主动联系玩家的客服，需要根据玩家是否想了解活动的意图来选择是否介绍。\n保持通话的专业性，同时语言平易近人，确保玩家轻松理解活动内容。\n明确活动的起止时间，确保玩家不会混淆。\n强调活动的重点奖励和参与方式，提升玩家的参与兴趣。\n鼓励玩家间的互动和反馈，以促进游戏社区的活跃度。\n结束通话时保持礼貌，给玩家留下良好印象。\n用户询问的问题与目标或流程无关时， 请礼貌拒绝，并引导到目标问题上。\n对于不知道的问题，请不要胡乱回复，需要礼貌回复“不清楚”，并引导到目标问题上。&quot;,
            ///     &quot;openingPrompt&quot;: &quot;尊敬的冒险者，您好！我是安妮，来自游戏客服团队。今天有幸与您连线，是想分享一项即将启动的独家福利活动，绝对会让您的探险之旅更加精彩纷呈！&quot;,
            ///     &quot;output&quot;: &quot;&quot;,
            ///     &quot;aiHangupOutput&quot;: &quot;&quot;,
            ///     &quot;aiSilenceTimeoutOutput&quot;: &quot;&quot;
            /// }</para>
            /// </summary>
            [NameInMap("PromptJson")]
            [Validation(Required=false)]
            public string PromptJson { get; set; }

            /// <summary>
            /// <para>Scenario</para>
            /// 
            /// <b>Example:</b>
            /// <para>场景</para>
            /// </summary>
            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

            /// <summary>
            /// <para>Scenario ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>d13ad2d3-3fe6-4352-b38b-bd6559047de8</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>Indicates whether this is a system template</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("System")]
            [Validation(Required=false)]
            public bool? System { get; set; }

            /// <summary>
            /// <para>Last update time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1737077564000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Variable configuration</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{
            ///     &quot;name&quot;: &quot;开始时间&quot;,
            ///     &quot;description&quot;: &quot;开始时间&quot;
            /// }, {
            ///     &quot;name&quot;: &quot;结束时间&quot;,
            ///     &quot;description&quot;: &quot;结束时间&quot;
            /// }]</para>
            /// </summary>
            [NameInMap("VariablesJson")]
            [Validation(Required=false)]
            public string VariablesJson { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
