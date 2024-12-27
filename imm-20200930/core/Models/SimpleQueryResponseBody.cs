// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SimpleQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The aggregations. This parameter is returned only when the value of the Aggregations request parameter is not empty.</para>
        /// </summary>
        [NameInMap("Aggregations")]
        [Validation(Required=false)]
        public List<SimpleQueryResponseBodyAggregations> Aggregations { get; set; }
        public class SimpleQueryResponseBodyAggregations : TeaModel {
            /// <summary>
            /// <para>The name of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Size</para>
            /// </summary>
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <para>The grouped aggregations. This parameter is returned only when the group operator is specified in the Aggregations request parameter.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<SimpleQueryResponseBodyAggregationsGroups> Groups { get; set; }
            public class SimpleQueryResponseBodyAggregationsGroups : TeaModel {
                /// <summary>
                /// <para>The number of results in the grouped aggregation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The value for the grouped aggregation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sum</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The statistical result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

        }

        /// <summary>
        /// <para>The files. This parameter is returned only when the value of the Aggregations request parameter is empty.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<File> Files { get; set; }

        /// <summary>
        /// <para>The pagination token is used in the next request to retrieve a new page of results if the total number of results exceeds the value of the MaxResults parameter.</para>
        /// <para>It can be used in the next request to retrieve a new page of results.</para>
        /// <para>If NextToken is empty, no next page exists.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg6aW1tdGVzdDpleGFtcGxlYnVja2V0OmRhdGFzZXQwMDE6b3NzOi8vZXhhbXBsZWJ1Y2tldC9zYW1wbGVvYmplY3QxLmpwZw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2C5C1E0F-D8B8-4DA0-8127-EC32C771****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of total hits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalHits")]
        [Validation(Required=false)]
        public long? TotalHits { get; set; }

    }

}
