// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20190901.Models
{
    public class SwitchSynchronizationEndpointRequest : TeaModel {
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public SwitchSynchronizationEndpointRequestEndpoint Endpoint { get; set; }
        public class SwitchSynchronizationEndpointRequestEndpoint : TeaModel {
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

    }

}
