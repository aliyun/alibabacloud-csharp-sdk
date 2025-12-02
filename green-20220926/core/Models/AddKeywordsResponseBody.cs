// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class AddKeywordsResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code. A return of 200 represents success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddKeywordsResponseBodyData Data { get; set; }
        public class AddKeywordsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Result.</para>
            /// </summary>
            [NameInMap("KeywordsResult")]
            [Validation(Required=false)]
            public AddKeywordsResponseBodyDataKeywordsResult KeywordsResult { get; set; }
            public class AddKeywordsResponseBodyDataKeywordsResult : TeaModel {
                /// <summary>
                /// <para>Internationalization key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("I18nKey")]
                [Validation(Required=false)]
                public string I18nKey { get; set; }

                /// <summary>
                /// <para>List of keywords that are too long or too short.</para>
                /// </summary>
                [NameInMap("IllegalLengthKeywords")]
                [Validation(Required=false)]
                public List<string> IllegalLengthKeywords { get; set; }

                /// <summary>
                /// <para>Invalid keyword count</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InvalidCount")]
                [Validation(Required=false)]
                public int? InvalidCount { get; set; }

                /// <summary>
                /// <para>List of invalid keywords</para>
                /// </summary>
                [NameInMap("InvalidKeywords")]
                [Validation(Required=false)]
                public List<string> InvalidKeywords { get; set; }

                /// <summary>
                /// <para>The keyword library ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customxx_xxxx</para>
                /// </summary>
                [NameInMap("LibId")]
                [Validation(Required=false)]
                public string LibId { get; set; }

                /// <summary>
                /// <para>The progress percentage of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>Duplicate keyword count</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RepeatCount")]
                [Validation(Required=false)]
                public int? RepeatCount { get; set; }

                /// <summary>
                /// <para>List of duplicate keywords</para>
                /// </summary>
                [NameInMap("RepeatKeywords")]
                [Validation(Required=false)]
                public List<string> RepeatKeywords { get; set; }

                /// <summary>
                /// <para>The success count of the keywords.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public int? SuccessCount { get; set; }

                /// <summary>
                /// <para>The tips.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("Tips")]
                [Validation(Required=false)]
                public string Tips { get; set; }

                /// <summary>
                /// <para>The total count of the keywords.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The ID of the keyword library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customxx_xxxx</para>
            /// </summary>
            [NameInMap("LibId")]
            [Validation(Required=false)]
            public string LibId { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx-xxxxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned in response to the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>ID assigned by the backend to uniquely identify a request. Can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Success indicator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
