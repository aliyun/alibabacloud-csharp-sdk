// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplateVersionsRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public List<int?> LaunchTemplateVersion { get; set; }

        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        [NameInMap("MinVersion")]
        [Validation(Required=false)]
        public long? MinVersion { get; set; }

        [NameInMap("MaxVersion")]
        [Validation(Required=false)]
        public long? MaxVersion { get; set; }

        [NameInMap("DefaultVersion")]
        [Validation(Required=false)]
        public bool? DefaultVersion { get; set; }

        [NameInMap("DetailFlag")]
        [Validation(Required=false)]
        public bool? DetailFlag { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
