// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class DescribeNavigationConfigResponseBody : TeaModel {
        [NameInMap("GreetingConfig")]
        [Validation(Required=false)]
        public DescribeNavigationConfigResponseBodyGreetingConfig GreetingConfig { get; set; }
        public class DescribeNavigationConfigResponseBodyGreetingConfig : TeaModel {
            [NameInMap("GreetingWords")]
            [Validation(Required=false)]
            public string GreetingWords { get; set; }

            [NameInMap("IntentTrigger")]
            [Validation(Required=false)]
            public string IntentTrigger { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>chatbotIntent</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>14C39896-AE6D-4643-9C9A-E0566B2C2DDD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SilenceTimeoutConfig")]
        [Validation(Required=false)]
        public DescribeNavigationConfigResponseBodySilenceTimeoutConfig SilenceTimeoutConfig { get; set; }
        public class DescribeNavigationConfigResponseBodySilenceTimeoutConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>HangUp</para>
            /// </summary>
            [NameInMap("FinalAction")]
            [Validation(Required=false)]
            public string FinalAction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("FinalActionParams")]
            [Validation(Required=false)]
            public string FinalActionParams { get; set; }

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

            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>chatbotIntent</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

        }

        [NameInMap("UnrecognizingConfig")]
        [Validation(Required=false)]
        public DescribeNavigationConfigResponseBodyUnrecognizingConfig UnrecognizingConfig { get; set; }
        public class DescribeNavigationConfigResponseBodyUnrecognizingConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>TransferToAgent</para>
            /// </summary>
            [NameInMap("FinalAction")]
            [Validation(Required=false)]
            public string FinalAction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{ \&quot;skillGroupId\&quot;: \&quot;fallbackSkillGroup\&quot; }</para>
            /// </summary>
            [NameInMap("FinalActionParams")]
            [Validation(Required=false)]
            public string FinalActionParams { get; set; }

            [NameInMap("FinalPrompt")]
            [Validation(Required=false)]
            public string FinalPrompt { get; set; }

            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

        }

    }

}
