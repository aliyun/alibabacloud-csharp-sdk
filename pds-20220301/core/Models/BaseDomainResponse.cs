// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BaseDomainResponse : TeaModel {
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("domain_name")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("init_drive_enable")]
        [Validation(Required=false)]
        public bool? InitDriveEnable { get; set; }

        [NameInMap("init_drive_size")]
        [Validation(Required=false)]
        public long? InitDriveSize { get; set; }

        [NameInMap("parent_domain_id")]
        [Validation(Required=false)]
        public string ParentDomainId { get; set; }

        [NameInMap("published_app_access_strategy")]
        [Validation(Required=false)]
        public AppAccessStrategy PublishedAppAccessStrategy { get; set; }

        [NameInMap("share_link_enabled")]
        [Validation(Required=false)]
        public bool? ShareLinkEnabled { get; set; }

        [NameInMap("size_quota")]
        [Validation(Required=false)]
        public long? SizeQuota { get; set; }

        [NameInMap("size_quota_used")]
        [Validation(Required=false)]
        public long? SizeQuotaUsed { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("used_size")]
        [Validation(Required=false)]
        public long? UsedSize { get; set; }

    }

}
