// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Uis20180821.Models
{
    public class DescribeSubConnectionResponseBody : TeaModel {
        [NameInMap("CustomerTunnelIp")]
        [Validation(Required=false)]
        public string CustomerTunnelIp { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("LocalTunnelIp")]
        [Validation(Required=false)]
        public string LocalTunnelIp { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UisId")]
        [Validation(Required=false)]
        public string UisId { get; set; }

        [NameInMap("CustomerIp")]
        [Validation(Required=false)]
        public string CustomerIp { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("UisNodeId")]
        [Validation(Required=false)]
        public string UisNodeId { get; set; }

        [NameInMap("UisSubConnectionId")]
        [Validation(Required=false)]
        public string UisSubConnectionId { get; set; }

        [NameInMap("CustomerSubnet")]
        [Validation(Required=false)]
        public string CustomerSubnet { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
