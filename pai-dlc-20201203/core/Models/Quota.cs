// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class Quota : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("EnableTideResource")]
        [Validation(Required=false)]
        public bool? EnableTideResource { get; set; }

        [NameInMap("IsExclusiveQuota")]
        [Validation(Required=false)]
        public bool? IsExclusiveQuota { get; set; }

        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        [NameInMap("QuotaType")]
        [Validation(Required=false)]
        public string QuotaType { get; set; }

        [NameInMap("ResourceLevel")]
        [Validation(Required=false)]
        public string ResourceLevel { get; set; }

        [NameInMap("TotalQuota")]
        [Validation(Required=false)]
        public QuotaDetail TotalQuota { get; set; }

        [NameInMap("TotalTideQuota")]
        [Validation(Required=false)]
        public QuotaDetail TotalTideQuota { get; set; }

        [NameInMap("UsedQuota")]
        [Validation(Required=false)]
        public QuotaDetail UsedQuota { get; set; }

        [NameInMap("UsedTideQuota")]
        [Validation(Required=false)]
        public QuotaDetail UsedTideQuota { get; set; }

    }

}
