// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SimpleQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of aggregation field information. This parameter is returned only when Aggregations in the request is not empty.</para>
        /// </summary>
        [NameInMap("Aggregations")]
        [Validation(Required=false)]
        public List<SimpleQueryResponseBodyAggregations> Aggregations { get; set; }
        public class SimpleQueryResponseBodyAggregations : TeaModel {
            /// <summary>
            /// <para>The name of the aggregation field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Size</para>
            /// </summary>
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <para>The list of grouping and aggregation results. This parameter is returned only when an Operation of the group type exists in Aggregations of the request.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<SimpleQueryResponseBodyAggregationsGroups> Groups { get; set; }
            public class SimpleQueryResponseBodyAggregationsGroups : TeaModel {
                /// <summary>
                /// <para>The total count of the grouping and aggregation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The value of the grouping and aggregation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The aggregation operation for the aggregation field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sum</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The statistical result of the aggregation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

        }

        /// <summary>
        /// <para>The list of file information. This parameter is returned only when Aggregations in the request is empty.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<File> Files { get; set; }

        /// <summary>
        /// <para>The token used for pagination when the total number of files exceeds the value of MaxResults.</para>
        /// <para>When you list file information next time, set NextToken to this value to return the remaining results.</para>
        /// <para>This parameter has a value only when not all files are returned.</para>
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
        /// <para>The number of matched records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalHits")]
        [Validation(Required=false)]
        public long? TotalHits { get; set; }

    }

}
