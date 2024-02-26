// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class ListTagsRequest : TeaModel {
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
