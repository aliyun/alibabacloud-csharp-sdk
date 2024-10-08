// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RecognizeIntentionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("analysis")]
        [Validation(Required=false)]
        public bool? Analysis { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>1810566978021232640</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>1810929291010150400</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>1808766224000262144</para>
            /// </summary>
            [NameInMap("intentionCode")]
            [Validation(Required=false)]
            public string IntentionCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("opType")]
        [Validation(Required=false)]
        public string OpType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("recommend")]
        [Validation(Required=false)]
        public bool? Recommend { get; set; }

    }

}
