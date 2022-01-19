// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SimpleQueryResponseBody : TeaModel {
        /// <summary>
        /// 聚合字段的字段名
        /// </summary>
        [NameInMap("Aggregations")]
        [Validation(Required=false)]
        public List<SimpleQueryResponseBodyAggregations> Aggregations { get; set; }
        public class SimpleQueryResponseBodyAggregations : TeaModel {
            /// <summary>
            /// 聚合字段名
            /// </summary>
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// 分组聚合的结果
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<SimpleQueryResponseBodyAggregationsGroups> Groups { get; set; }
            public class SimpleQueryResponseBodyAggregationsGroups : TeaModel {
                /// <summary>
                /// 分组聚合的计数
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// 分组聚合的值
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 聚合字段的聚合操作符
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 文件列表
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<File> Files { get; set; }

        /// <summary>
        /// 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 本次请求的唯一 Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
