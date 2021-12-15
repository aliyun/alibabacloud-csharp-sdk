// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeDomainBasicConfigsRequest : TeaModel {
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        [NameInMap("CloudNativeProductId")]
        [Validation(Required=false)]
        public int? CloudNativeProductId { get; set; }

        [NameInMap("DomainKey")]
        [Validation(Required=false)]
        public string DomainKey { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
