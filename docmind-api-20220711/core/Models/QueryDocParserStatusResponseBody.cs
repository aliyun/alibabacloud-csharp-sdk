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

            [NameInMap("PageCountEstimate")]
            [Validation(Required=false)]
            public int? PageCountEstimate { get; set; }

            [NameInMap("ParagraphCount")]
            [Validation(Required=false)]
            public int? ParagraphCount { get; set; }

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
