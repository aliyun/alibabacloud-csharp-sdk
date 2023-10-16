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

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SilenceTimeoutConfig")]
        [Validation(Required=false)]
        public DescribeNavigationConfigResponseBodySilenceTimeoutConfig SilenceTimeoutConfig { get; set; }
        public class DescribeNavigationConfigResponseBodySilenceTimeoutConfig : TeaModel {
            [NameInMap("FinalAction")]
            [Validation(Required=false)]
            public string FinalAction { get; set; }

            [NameInMap("FinalActionParams")]
            [Validation(Required=false)]
            public string FinalActionParams { get; set; }

            [NameInMap("FinalPrompt")]
            [Validation(Required=false)]
            public string FinalPrompt { get; set; }

            /// <summary>
            /// ""
            /// </summary>
            [NameInMap("IntentTrigger")]
            [Validation(Required=false)]
            public string IntentTrigger { get; set; }

            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

        }

        [NameInMap("UnrecognizingConfig")]
        [Validation(Required=false)]
        public DescribeNavigationConfigResponseBodyUnrecognizingConfig UnrecognizingConfig { get; set; }
        public class DescribeNavigationConfigResponseBodyUnrecognizingConfig : TeaModel {
            [NameInMap("FinalAction")]
            [Validation(Required=false)]
            public string FinalAction { get; set; }

            [NameInMap("FinalActionParams")]
            [Validation(Required=false)]
            public string FinalActionParams { get; set; }

            [NameInMap("FinalPrompt")]
            [Validation(Required=false)]
            public string FinalPrompt { get; set; }

            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

        }

    }

}
