// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class AddKeywordsToLibResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddKeywordsToLibResponseBodyData Data { get; set; }
        public class AddKeywordsToLibResponseBodyData : TeaModel {
            [NameInMap("KeywordsResult")]
            [Validation(Required=false)]
            public AddKeywordsToLibResponseBodyDataKeywordsResult KeywordsResult { get; set; }
            public class AddKeywordsToLibResponseBodyDataKeywordsResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("I18nKey")]
                [Validation(Required=false)]
                public string I18nKey { get; set; }

                [NameInMap("IllegalLengthKeywords")]
                [Validation(Required=false)]
                public List<string> IllegalLengthKeywords { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InvalidCount")]
                [Validation(Required=false)]
                public int? InvalidCount { get; set; }

                [NameInMap("InvalidKeywords")]
                [Validation(Required=false)]
                public List<string> InvalidKeywords { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>customxx_xxxx</para>
                /// </summary>
                [NameInMap("LibId")]
                [Validation(Required=false)]
                public string LibId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RepeatCount")]
                [Validation(Required=false)]
                public int? RepeatCount { get; set; }

                [NameInMap("RepeatKeywords")]
                [Validation(Required=false)]
                public List<string> RepeatKeywords { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public int? SuccessCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>customxx_xxxx</para>
            /// </summary>
            [NameInMap("LibId")]
            [Validation(Required=false)]
            public string LibId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxx-xxxxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
