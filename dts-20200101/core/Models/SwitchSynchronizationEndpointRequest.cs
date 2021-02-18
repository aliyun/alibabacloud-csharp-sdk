// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class SwitchSynchronizationEndpointRequest : TeaModel {
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public SwitchSynchronizationEndpointRequestEndpoint Endpoint { get; set; }
        public class SwitchSynchronizationEndpointRequestEndpoint : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }
        };

        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public SwitchSynchronizationEndpointRequestSourceEndpoint SourceEndpoint { get; set; }
        public class SwitchSynchronizationEndpointRequestSourceEndpoint : TeaModel {
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }
        };

        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

    }

}
