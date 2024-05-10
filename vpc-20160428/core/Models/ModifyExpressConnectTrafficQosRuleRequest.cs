// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyExpressConnectTrafficQosRuleRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DstCidr")]
        [Validation(Required=false)]
        public string DstCidr { get; set; }

        [NameInMap("DstIPv6Cidr")]
        [Validation(Required=false)]
        public string DstIPv6Cidr { get; set; }

        [NameInMap("DstPortRange")]
        [Validation(Required=false)]
        public string DstPortRange { get; set; }

        [NameInMap("MatchDscp")]
        [Validation(Required=false)]
        public int? MatchDscp { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public string QueueId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RemarkingDscp")]
        [Validation(Required=false)]
        public int? RemarkingDscp { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("RuleDescription")]
        [Validation(Required=false)]
        public string RuleDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("SrcCidr")]
        [Validation(Required=false)]
        public string SrcCidr { get; set; }

        [NameInMap("SrcIPv6Cidr")]
        [Validation(Required=false)]
        public string SrcIPv6Cidr { get; set; }

        [NameInMap("SrcPortRange")]
        [Validation(Required=false)]
        public string SrcPortRange { get; set; }

    }

}
