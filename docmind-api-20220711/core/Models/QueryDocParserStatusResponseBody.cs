// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class QueryDocParserStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>noPermission</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDocParserStatusResponseBodyData Data { get; set; }
        public class QueryDocParserStatusResponseBodyData : TeaModel {
            [NameInMap("ImageCount")]
            [Validation(Required=false)]
            public int? ImageCount { get; set; }

            [NameInMap("NumberOfSuccessfulParsing")]
            [Validation(Required=false)]
            public int? NumberOfSuccessfulParsing { get; set; }

            [NameInMap("OutputFormatResult")]
            [Validation(Required=false)]
            public List<QueryDocParserStatusResponseBodyDataOutputFormatResult> OutputFormatResult { get; set; }
            public class QueryDocParserStatusResponseBodyDataOutputFormatResult : TeaModel {
                [NameInMap("OutputFileUrl")]
                [Validation(Required=false)]
                public string OutputFileUrl { get; set; }

                [NameInMap("OutputType")]
                [Validation(Required=false)]
                public string OutputType { get; set; }

                [NameInMap("Pages")]
                [Validation(Required=false)]
                public List<QueryDocParserStatusResponseBodyDataOutputFormatResultPages> Pages { get; set; }
                public class QueryDocParserStatusResponseBodyDataOutputFormatResultPages : TeaModel {
                    [NameInMap("ImageHeight")]
                    [Validation(Required=false)]
                    public int? ImageHeight { get; set; }

                    [NameInMap("ImageUrl")]
                    [Validation(Required=false)]
                    public string ImageUrl { get; set; }

                    [NameInMap("ImageWidth")]
                    [Validation(Required=false)]
                    public int? ImageWidth { get; set; }

                    [NameInMap("PageIdAllDocs")]
                    [Validation(Required=false)]
                    public int? PageIdAllDocs { get; set; }

                    [NameInMap("PageIdCurDoc")]
                    [Validation(Required=false)]
                    public int? PageIdCurDoc { get; set; }

                }

            }

            [NameInMap("PageCountEstimate")]
            [Validation(Required=false)]
            public int? PageCountEstimate { get; set; }

            [NameInMap("ParagraphCount")]
            [Validation(Required=false)]
            public int? ParagraphCount { get; set; }

            [NameInMap("Processing")]
            [Validation(Required=false)]
            public float? Processing { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TableCount")]
            [Validation(Required=false)]
            public int? TableCount { get; set; }

            [NameInMap("Tokens")]
            [Validation(Required=false)]
            public long? Tokens { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43A29C77-405E-4CC0-BC55-EE694AD00655</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
