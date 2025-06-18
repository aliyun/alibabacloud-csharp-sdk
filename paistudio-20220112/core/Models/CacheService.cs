// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CacheService : TeaModel {
        [NameInMap("CacheInfos")]
        [Validation(Required=false)]
        public List<CacheInfo> CacheInfos { get; set; }

        [NameInMap("CacheServiceId")]
        [Validation(Required=false)]
        public string CacheServiceId { get; set; }

        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SupportedClientQuotaIds")]
        [Validation(Required=false)]
        public List<string> SupportedClientQuotaIds { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

    }

}
