// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeModelsResponseBody : TeaModel {
        [NameInMap("ModelDetails")]
        [Validation(Required=false)]
        public DescribeModelsResponseBodyModelDetails ModelDetails { get; set; }
        public class DescribeModelsResponseBodyModelDetails : TeaModel {
            [NameInMap("ModelDetail")]
            [Validation(Required=false)]
            public List<DescribeModelsResponseBodyModelDetailsModelDetail> ModelDetail { get; set; }
            public class DescribeModelsResponseBodyModelDetailsModelDetail : TeaModel {
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                [NameInMap("ModelRef")]
                [Validation(Required=false)]
                public string ModelRef { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
