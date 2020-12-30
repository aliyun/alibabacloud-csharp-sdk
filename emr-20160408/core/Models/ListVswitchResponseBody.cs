// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListVswitchResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VswitchList")]
        [Validation(Required=false)]
        public ListVswitchResponseBodyVswitchList VswitchList { get; set; }
        public class ListVswitchResponseBodyVswitchList : TeaModel {
            [NameInMap("Vswitch")]
            [Validation(Required=false)]
            public List<ListVswitchResponseBodyVswitchListVswitch> Vswitch { get; set; }
            public class ListVswitchResponseBodyVswitchListVswitch : TeaModel {
                public string CreationTime { get; set; }
                public string Status { get; set; }
                public string VpcId { get; set; }
                public bool? IsDefault { get; set; }
                public string VSwitchId { get; set; }
                public string CidrBlock { get; set; }
                public string Description { get; set; }
                public string AvailableIpAddressCount { get; set; }
                public string ResourceGroupId { get; set; }
                public string ZoneId { get; set; }
                public string VSwitchName { get; set; }
            }
        };

    }

}
