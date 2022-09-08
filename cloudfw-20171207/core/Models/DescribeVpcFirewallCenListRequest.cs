// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallCenListRequest : TeaModel {
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        [NameInMap("FirewallSwitchStatus")]
        [Validation(Required=false)]
        public string FirewallSwitchStatus { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        [NameInMap("NetworkInstanceId")]
        [Validation(Required=false)]
        public string NetworkInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        [NameInMap("RouteMode")]
        [Validation(Required=false)]
        public string RouteMode { get; set; }

        [NameInMap("TransitRouterType")]
        [Validation(Required=false)]
        public string TransitRouterType { get; set; }

        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

    }

}
