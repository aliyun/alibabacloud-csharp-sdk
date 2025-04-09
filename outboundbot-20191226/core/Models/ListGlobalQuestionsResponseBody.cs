// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListGlobalQuestionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GlobalQuestions")]
        [Validation(Required=false)]
        public ListGlobalQuestionsResponseBodyGlobalQuestions GlobalQuestions { get; set; }
        public class ListGlobalQuestionsResponseBodyGlobalQuestions : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListGlobalQuestionsResponseBodyGlobalQuestionsList> List { get; set; }
            public class ListGlobalQuestionsResponseBodyGlobalQuestionsList : TeaModel {
                [NameInMap("Answers")]
                [Validation(Required=false)]
                public string Answers { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>53c27755-d41e-46a6-bb3c-4f66f257d50c</para>
                /// </summary>
                [NameInMap("GlobalQuestionId")]
                [Validation(Required=false)]
                public string GlobalQuestionId { get; set; }

                [NameInMap("GlobalQuestionName")]
                [Validation(Required=false)]
                public string GlobalQuestionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("GlobalQuestionType")]
                [Validation(Required=false)]
                public string GlobalQuestionType { get; set; }

                [NameInMap("Questions")]
                [Validation(Required=false)]
                public string Questions { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aa279896-64a6-4182-864c-4f2b04ec8d17</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
