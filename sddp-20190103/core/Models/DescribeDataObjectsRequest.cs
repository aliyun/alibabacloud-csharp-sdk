// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataObjectsRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public long? DomainId { get; set; }

        [NameInMap("FileType")]
        [Validation(Required=false)]
        public long? FileType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("ModelIds")]
        [Validation(Required=false)]
        public string ModelIds { get; set; }

        [NameInMap("ModelTagIds")]
        [Validation(Required=false)]
        public string ModelTagIds { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ParentCategoryIds")]
        [Validation(Required=false)]
        public string ParentCategoryIds { get; set; }

        [NameInMap("ProductIds")]
        [Validation(Required=false)]
        public string ProductIds { get; set; }

        [NameInMap("QueryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        [NameInMap("RiskLevels")]
        [Validation(Required=false)]
        public string RiskLevels { get; set; }

        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
