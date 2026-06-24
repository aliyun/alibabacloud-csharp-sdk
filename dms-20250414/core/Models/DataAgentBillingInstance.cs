// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DataAgentBillingInstance : TeaModel {
        [NameInMap("AgentSeats")]
        [Validation(Required=false)]
        public int? AgentSeats { get; set; }

        [NameInMap("BillingInstanceId")]
        [Validation(Required=false)]
        public string BillingInstanceId { get; set; }

        [NameInMap("BoundWorkspaceIds")]
        [Validation(Required=false)]
        public List<string> BoundWorkspaceIds { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        [NameInMap("FreeAgentSeats")]
        [Validation(Required=false)]
        public int? FreeAgentSeats { get; set; }

        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public long? GmtCreated { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        [NameInMap("LLM")]
        [Validation(Required=false)]
        public int? LLM { get; set; }

        [NameInMap("PayLevel")]
        [Validation(Required=false)]
        public string PayLevel { get; set; }

        [NameInMap("SessionAvailableDurationQuota")]
        [Validation(Required=false)]
        public int? SessionAvailableDurationQuota { get; set; }

        [NameInMap("SessionSeats")]
        [Validation(Required=false)]
        public int? SessionSeats { get; set; }

        [NameInMap("TokenLimit")]
        [Validation(Required=false)]
        public int? TokenLimit { get; set; }

    }

}
