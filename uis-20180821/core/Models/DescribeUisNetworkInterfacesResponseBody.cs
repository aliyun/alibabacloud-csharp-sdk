// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Uis20180821.Models
{
    public class DescribeUisNetworkInterfacesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("NetworkInterfaces")]
        [Validation(Required=false)]
        public DescribeUisNetworkInterfacesResponseBodyNetworkInterfaces NetworkInterfaces { get; set; }
        public class DescribeUisNetworkInterfacesResponseBodyNetworkInterfaces : TeaModel {
            [NameInMap("NetworkInterface")]
            [Validation(Required=false)]
            public List<DescribeUisNetworkInterfacesResponseBodyNetworkInterfacesNetworkInterface> NetworkInterface { get; set; }
            public class DescribeUisNetworkInterfacesResponseBodyNetworkInterfacesNetworkInterface : TeaModel {
                public string UisEniId { get; set; }
                public string UisNodeId { get; set; }
                public string IpAddress { get; set; }
                public string Description { get; set; }
                public string VswitchId { get; set; }
                public string State { get; set; }
                public string SecurityGroupID { get; set; }
                public string NetworkInterfaceId { get; set; }
                public string Name { get; set; }
                public string Log { get; set; }
            }
        };

    }

}
