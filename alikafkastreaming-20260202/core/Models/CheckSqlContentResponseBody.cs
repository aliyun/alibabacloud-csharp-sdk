// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaStreaming20260202.Models
{
    public class CheckSqlContentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckSqlContentResponseBodyData Data { get; set; }
        public class CheckSqlContentResponseBodyData : TeaModel {
            [NameInMap("ErrorList")]
            [Validation(Required=false)]
            public List<CheckSqlContentResponseBodyDataErrorList> ErrorList { get; set; }
            public class CheckSqlContentResponseBodyDataErrorList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>SELECT FROM source_table</para>
                /// </summary>
                [NameInMap("CodeSnippet")]
                [Validation(Required=false)]
                public string CodeSnippet { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("ColumnNumber")]
                [Validation(Required=false)]
                public int? ColumnNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("EndColumnNumber")]
                [Validation(Required=false)]
                public int? EndColumnNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EndLineNumber")]
                [Validation(Required=false)]
                public int? EndLineNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SYNTAX_ERROR</para>
                /// </summary>
                [NameInMap("ErrorType")]
                [Validation(Required=false)]
                public string ErrorType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LineNumber")]
                [Validation(Required=false)]
                public int? LineNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SQL parse failed near FROM</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Valid")]
            [Validation(Required=false)]
            public bool? Valid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>062D8E8B-8D47-5DCC-BB12-5A1D93C3A66B</para>
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
