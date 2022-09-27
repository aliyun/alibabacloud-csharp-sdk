// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventGroupRequest : TeaModel {
        [NameInMap("AttackApp")]
        [Validation(Required=false)]
        public List<string> AttackApp { get; set; }

        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public string AttackType { get; set; }

        [NameInMap("BuyVersion")]
        [Validation(Required=false)]
        public long? BuyVersion { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        [NameInMap("DstNetworkInstanceId")]
        [Validation(Required=false)]
        public string DstNetworkInstanceId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public string FirewallType { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("NoLocation")]
        [Validation(Required=false)]
        public string NoLocation { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RuleResult")]
        [Validation(Required=false)]
        public string RuleResult { get; set; }

        [NameInMap("RuleSource")]
        [Validation(Required=false)]
        public string RuleSource { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("SrcIP")]
        [Validation(Required=false)]
        public string SrcIP { get; set; }

        [NameInMap("SrcNetworkInstanceId")]
        [Validation(Required=false)]
        public string SrcNetworkInstanceId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("VulLevel")]
        [Validation(Required=false)]
        public string VulLevel { get; set; }

    }

}
