// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class DescribeNavigationConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The greeting configuration.</para>
        /// </summary>
        [NameInMap("GreetingConfig")]
        [Validation(Required=false)]
        public DescribeNavigationConfigResponseBodyGreetingConfig GreetingConfig { get; set; }
        public class DescribeNavigationConfigResponseBodyGreetingConfig : TeaModel {
            /// <summary>
            /// <para>The greeting message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>您好，欢迎致电智能导航</para>
            /// </summary>
            [NameInMap("GreetingWords")]
            [Validation(Required=false)]
            public string GreetingWords { get; set; }

            /// <summary>
            /// <para>The intent trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>你好</para>
            /// </summary>
            [NameInMap("IntentTrigger")]
            [Validation(Required=false)]
            public string IntentTrigger { get; set; }

            /// <summary>
            /// <para>The source of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chatbotIntent</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14C39896-AE6D-4643-9C9A-E0566B2C2DDD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The silence timeout configuration.</para>
        /// </summary>
        [NameInMap("SilenceTimeoutConfig")]
        [Validation(Required=false)]
        public DescribeNavigationConfigResponseBodySilenceTimeoutConfig SilenceTimeoutConfig { get; set; }
        public class DescribeNavigationConfigResponseBodySilenceTimeoutConfig : TeaModel {
            /// <summary>
            /// <para>The action to perform after the final silence prompt is played. Valid values: <c>TransferToAgent</c>, <c>TransferToIVR</c>, <c>RedirectToPage</c>, or <c>HangUp</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HangUp</para>
            /// </summary>
            [NameInMap("FinalAction")]
            [Validation(Required=false)]
            public string FinalAction { get; set; }

            /// <summary>
            /// <para>Parameters for the final action, such as a redirection target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("FinalActionParams")]
            [Validation(Required=false)]
            public string FinalActionParams { get; set; }

            /// <summary>
            /// <para>The prompt that is played when the silence timeout threshold is reached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>抱歉，听不到您说话，请您稍后致电</para>
            /// </summary>
            [NameInMap("FinalPrompt")]
            [Validation(Required=false)]
            public string FinalPrompt { get; set; }

            /// <summary>
            /// <para>&quot;&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("IntentTrigger")]
            [Validation(Required=false)]
            public string IntentTrigger { get; set; }

            /// <summary>
            /// <para>The prompt that is played when a silence timeout occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>抱歉，我没听到您说话</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>The source of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chatbotIntent</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The maximum number of silence timeouts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

            /// <summary>
            /// <para>The duration of the silence timeout.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

        }

        /// <summary>
        /// <para>The configuration for handling unrecognized input.</para>
        /// </summary>
        [NameInMap("UnrecognizingConfig")]
        [Validation(Required=false)]
        public DescribeNavigationConfigResponseBodyUnrecognizingConfig UnrecognizingConfig { get; set; }
        public class DescribeNavigationConfigResponseBodyUnrecognizingConfig : TeaModel {
            /// <summary>
            /// <para>The action to take when the number of unrecognized inputs reaches the threshold. Valid values: <c>TransferToAgent</c>, <c>TransferToIVR</c>, <c>RedirectToPage</c>, or <c>HangUp</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TransferToAgent</para>
            /// </summary>
            [NameInMap("FinalAction")]
            [Validation(Required=false)]
            public string FinalAction { get; set; }

            /// <summary>
            /// <para>Parameters for the final action, such as a redirection target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ \&quot;skillGroupId\&quot;: \&quot;fallbackSkillGroup\&quot; }</para>
            /// </summary>
            [NameInMap("FinalActionParams")]
            [Validation(Required=false)]
            public string FinalActionParams { get; set; }

            /// <summary>
            /// <para>The prompt that is played when the unrecognized input threshold is reached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>抱歉，我暂时无法处理您的问题，即将为您转接人工</para>
            /// </summary>
            [NameInMap("FinalPrompt")]
            [Validation(Required=false)]
            public string FinalPrompt { get; set; }

            /// <summary>
            /// <para>The prompt that is played when user input is not recognized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>抱歉，我无法理解您的意思</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>The maximum number of times the user\&quot;s input is not recognized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

        }

    }

}
