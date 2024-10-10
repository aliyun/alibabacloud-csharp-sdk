// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>a4d1a221d-41za1-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDataResponseBodyResult Result { get; set; }
        public class QueryDataResponseBodyResult : TeaModel {
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public List<QueryDataResponseBodyResultHeaders> Headers { get; set; }
            public class QueryDataResponseBodyResultHeaders : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>SUM</para>
                /// </summary>
                [NameInMap("Aggregator")]
                [Validation(Required=false)]
                public string Aggregator { get; set; }

                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>REGION</para>
                /// </summary>
                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public string Granularity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>area</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Dimension</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Values { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
