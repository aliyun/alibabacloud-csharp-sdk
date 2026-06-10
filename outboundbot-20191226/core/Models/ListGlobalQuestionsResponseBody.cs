// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListGlobalQuestionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The global question data.</para>
        /// </summary>
        [NameInMap("GlobalQuestions")]
        [Validation(Required=false)]
        public ListGlobalQuestionsResponseBodyGlobalQuestions GlobalQuestions { get; set; }
        public class ListGlobalQuestionsResponseBodyGlobalQuestions : TeaModel {
            /// <summary>
            /// <para>The array of global questions.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListGlobalQuestionsResponseBodyGlobalQuestionsList> List { get; set; }
            public class ListGlobalQuestionsResponseBodyGlobalQuestionsList : TeaModel {
                /// <summary>
                /// <para>The replies to the global question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;你好,您可以再说一遍吗&quot;,&quot;不好意思我刚才没有听清&quot;]</para>
                /// </summary>
                [NameInMap("Answers")]
                [Validation(Required=false)]
                public string Answers { get; set; }

                /// <summary>
                /// <para>The global question ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>53c27755-d41e-46a6-bb3c-4f66f257d50c</para>
                /// </summary>
                [NameInMap("GlobalQuestionId")]
                [Validation(Required=false)]
                public string GlobalQuestionId { get; set; }

                /// <summary>
                /// <para>The name of the global question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>未识别</para>
                /// </summary>
                [NameInMap("GlobalQuestionName")]
                [Validation(Required=false)]
                public string GlobalQuestionName { get; set; }

                /// <summary>
                /// <para>The type of the global question.</para>
                /// <list type="bullet">
                /// <item><description><para>SYSTEM: System-defined</para>
                /// </description></item>
                /// <item><description><para>COMMON: General</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("GlobalQuestionType")]
                [Validation(Required=false)]
                public string GlobalQuestionType { get; set; }

                /// <summary>
                /// <para>The list of global questions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;测试问题1&quot;,&quot;测试问题2&quot;]</para>
                /// </summary>
                [NameInMap("Questions")]
                [Validation(Required=false)]
                public string Questions { get; set; }

                /// <summary>
                /// <para>The scenario ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aa279896-64a6-4182-864c-4f2b04ec8d17</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
