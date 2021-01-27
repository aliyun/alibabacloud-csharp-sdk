// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateListenerRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ClientAffinity")]
        [Validation(Required=false)]
        public string ClientAffinity { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("ProxyProtocol")]
        [Validation(Required=false)]
        public bool? ProxyProtocol { get; set; }

        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<CreateListenerRequestPortRanges> PortRanges { get; set; }
        public class CreateListenerRequestPortRanges : TeaModel {
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCertificates> Certificates { get; set; }
        public class CreateListenerRequestCertificates : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// 转发端口迁移至终端节点组portoverride
        /// </summary>
        [NameInMap("BackendPorts")]
        [Validation(Required=false)]
        public List<CreateListenerRequestBackendPorts> BackendPorts { get; set; }
        public class CreateListenerRequestBackendPorts : TeaModel {
        }

    }

}
