// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RecognizeIntentionRequest : TeaModel {
        [NameInMap("analysis")]
        [Validation(Required=false)]
        public bool? Analysis { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("conversation")]
        [Validation(Required=false)]
        public string Conversation { get; set; }

        [NameInMap("globalIntentionList")]
        [Validation(Required=false)]
        public List<RecognizeIntentionRequestGlobalIntentionList> GlobalIntentionList { get; set; }
        public class RecognizeIntentionRequestGlobalIntentionList : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("intention")]
            [Validation(Required=false)]
            public string Intention { get; set; }

            [NameInMap("intentionCode")]
            [Validation(Required=false)]
            public string IntentionCode { get; set; }

        }

        [NameInMap("hierarchicalIntentionList")]
        [Validation(Required=false)]
        public List<RecognizeIntentionRequestHierarchicalIntentionList> HierarchicalIntentionList { get; set; }
        public class RecognizeIntentionRequestHierarchicalIntentionList : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("intention")]
            [Validation(Required=false)]
            public string Intention { get; set; }

            [NameInMap("intentionCode")]
            [Validation(Required=false)]
            public string IntentionCode { get; set; }

        }

        [NameInMap("intentionList")]
        [Validation(Required=false)]
        public List<RecognizeIntentionRequestIntentionList> IntentionList { get; set; }
        public class RecognizeIntentionRequestIntentionList : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("intention")]
            [Validation(Required=false)]
            public string Intention { get; set; }

            [NameInMap("intentionCode")]
            [Validation(Required=false)]
            public string IntentionCode { get; set; }

        }

        [NameInMap("opType")]
        [Validation(Required=false)]
        public string OpType { get; set; }

        [NameInMap("recommend")]
        [Validation(Required=false)]
        public bool? Recommend { get; set; }

    }

}
