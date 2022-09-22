// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeCustomerIssueCategoryResponseBody : TeaModel {
        [NameInMap("IssueCategoryModelList")]
        [Validation(Required=false)]
        public List<DescribeCustomerIssueCategoryResponseBodyIssueCategoryModelList> IssueCategoryModelList { get; set; }
        public class DescribeCustomerIssueCategoryResponseBodyIssueCategoryModelList : TeaModel {
            [NameInMap("IssueCategoryId")]
            [Validation(Required=false)]
            public long? IssueCategoryId { get; set; }

            [NameInMap("IssueCategoryName")]
            [Validation(Required=false)]
            public string IssueCategoryName { get; set; }

            [NameInMap("IssueCategoryParentId")]
            [Validation(Required=false)]
            public long? IssueCategoryParentId { get; set; }

            [NameInMap("Layer")]
            [Validation(Required=false)]
            public long? Layer { get; set; }

            [NameInMap("MappingTools")]
            [Validation(Required=false)]
            public string MappingTools { get; set; }

            [NameInMap("MetricSetId")]
            [Validation(Required=false)]
            public string MetricSetId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
