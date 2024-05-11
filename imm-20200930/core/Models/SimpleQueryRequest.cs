// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SimpleQueryRequest : TeaModel {
        [NameInMap("Aggregations")]
        [Validation(Required=false)]
        public List<SimpleQueryRequestAggregations> Aggregations { get; set; }
        public class SimpleQueryRequestAggregations : TeaModel {
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public SimpleQuery Query { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("WithFields")]
        [Validation(Required=false)]
        public List<string> WithFields { get; set; }

        [NameInMap("WithoutTotalHits")]
        [Validation(Required=false)]
        public bool? WithoutTotalHits { get; set; }

    }

}
