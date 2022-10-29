// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCustomRoutingEndpointGroupResponseBody : TeaModel {
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("AccessLogSwitch")]
        [Validation(Required=false)]
        public string AccessLogSwitch { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnableAccessLog")]
        [Validation(Required=false)]
        public bool? EnableAccessLog { get; set; }

        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        [NameInMap("EndpointGroupIpList")]
        [Validation(Required=false)]
        public List<string> EndpointGroupIpList { get; set; }

        [NameInMap("EndpointGroupRegion")]
        [Validation(Required=false)]
        public string EndpointGroupRegion { get; set; }

        [NameInMap("EndpointGroupUnconfirmedIpList")]
        [Validation(Required=false)]
        public List<string> EndpointGroupUnconfirmedIpList { get; set; }

        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlsLogStoreName")]
        [Validation(Required=false)]
        public string SlsLogStoreName { get; set; }

        [NameInMap("SlsProjectName")]
        [Validation(Required=false)]
        public string SlsProjectName { get; set; }

        [NameInMap("SlsRegion")]
        [Validation(Required=false)]
        public string SlsRegion { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
