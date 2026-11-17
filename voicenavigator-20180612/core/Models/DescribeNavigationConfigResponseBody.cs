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
            /// <para>The greeting words.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello, welcome to the intelligent navigation service</para>
            /// </summary>
            [NameInMap("GreetingWords")]
            [Validation(Required=false)]
            public string GreetingWords { get; set; }

            /// <summary>
            /// <para>The trigger intent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello</para>
            /// </summary>
            [NameInMap("IntentTrigger")]
            [Validation(Required=false)]
            public string IntentTrigger { get; set; }

            /// <summary>
            /// <para>The configuration type.</para>
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
            /// <para>The action to perform after the prompt. Valid values: TransferToAgent, TransferToIVR, RedirectToPage, and HangUp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HangUp</para>
            /// </summary>
            [NameInMap("FinalAction")]
            [Validation(Required=false)]
            public string FinalAction { get; set; }

            /// <summary>
            /// <para>The action parameters, such as the redirect target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("FinalActionParams")]
            [Validation(Required=false)]
            public string FinalActionParams { get; set; }

            /// <summary>
            /// <para>The final silence prompt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sorry, I cannot hear you. Please call back later</para>
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
            /// <para>The silence timeout prompt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sorry, I did not hear you</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>The source type of the configuration.</para>
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
            /// <para>The silence timeout period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

        }

        /// <summary>
        /// <para>The unrecognizing configuration.</para>
        /// </summary>
        [NameInMap("UnrecognizingConfig")]
        [Validation(Required=false)]
        public DescribeNavigationConfigResponseBodyUnrecognizingConfig UnrecognizingConfig { get; set; }
        public class DescribeNavigationConfigResponseBodyUnrecognizingConfig : TeaModel {
            /// <summary>
            /// <para>The action to perform for unrecognized input. Valid values: TransferToAgent, TransferToIVR, RedirectToPage, and HangUp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TransferToAgent</para>
            /// </summary>
            [NameInMap("FinalAction")]
            [Validation(Required=false)]
            public string FinalAction { get; set; }

            /// <summary>
            /// <para>The action parameters, such as the redirect target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ \&quot;skillGroupId\&quot;: \&quot;fallbackSkillGroup\&quot; }</para>
            /// </summary>
            [NameInMap("FinalActionParams")]
            [Validation(Required=false)]
            public string FinalActionParams { get; set; }

            /// <summary>
            /// <para>The final prompt for unrecognized input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sorry, I cannot process your request at the moment. I am transferring you to a human agent</para>
            /// </summary>
            [NameInMap("FinalPrompt")]
            [Validation(Required=false)]
            public string FinalPrompt { get; set; }

            /// <summary>
            /// <para>The prompt for unrecognized input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sorry, I do not understand what you mean</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>The maximum number of unrecognized inputs.</para>
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
