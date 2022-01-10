// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class ListMediaShrinkRequest : TeaModel {
        [NameInMap("AccessStatus")]
        [Validation(Required=false)]
        public string AccessStatus { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Business")]
        [Validation(Required=false)]
        public string Business { get; set; }

        [NameInMap("EndCreateTime")]
        [Validation(Required=false)]
        public long? EndCreateTime { get; set; }

        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        [NameInMap("FirstScene")]
        [Validation(Required=false)]
        public string FirstScene { get; set; }

        [NameInMap("MediaName")]
        [Validation(Required=false)]
        public string MediaNameShrink { get; set; }

        [NameInMap("MediaStatus")]
        [Validation(Required=false)]
        public string MediaStatus { get; set; }

        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        [NameInMap("OriginSiteUserId")]
        [Validation(Required=false)]
        public string OriginSiteUserId { get; set; }

        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SecondScene")]
        [Validation(Required=false)]
        public string SecondScene { get; set; }

        [NameInMap("StartCreateTime")]
        [Validation(Required=false)]
        public long? StartCreateTime { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserSite")]
        [Validation(Required=false)]
        public string UserSite { get; set; }

    }

}
