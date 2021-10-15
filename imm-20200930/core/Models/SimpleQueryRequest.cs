// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SimpleQueryRequest : TeaModel {
        /// <summary>
        /// 聚合字段
        /// </summary>
        [NameInMap("Aggregations")]
        [Validation(Required=false)]
        public List<SimpleQueryRequestAggregations> Aggregations { get; set; }
        public class SimpleQueryRequestAggregations : TeaModel {
            /// <summary>
            /// 聚合字段的字段名
            /// </summary>
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// 聚合字段的聚合操作符
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

        }

        /// <summary>
        /// Dataset 名称
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// 本次读取的最大数据记录数量
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 标记当前开始读取的位置，置空表示从头开始
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public SimpleQuery Query { get; set; }

        /// <summary>
        /// 排序方式，默认 DESC
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

    }

}
