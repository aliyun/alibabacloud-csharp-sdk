// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeTrafficRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Ipnet")]
        [Validation(Required=false)]
        public string Ipnet { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public int? StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        [NameInMap("FlowType")]
        [Validation(Required=false)]
        public string FlowType { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
