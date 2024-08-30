// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaTopo : TeaModel {
        [NameInMap("Depth")]
        [Validation(Required=false)]
        public string Depth { get; set; }

        [NameInMap("ParentQuotaId")]
        [Validation(Required=false)]
        public string ParentQuotaId { get; set; }

        [NameInMap("QuotaDetails")]
        [Validation(Required=false)]
        public QuotaDetails QuotaDetails { get; set; }

        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("WorkloadDetails")]
        [Validation(Required=false)]
        public WorkloadDetails WorkloadDetails { get; set; }

    }

}
