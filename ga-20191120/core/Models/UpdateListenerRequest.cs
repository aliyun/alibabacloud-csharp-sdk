// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateListenerRequest : TeaModel {
        [NameInMap("BackendPorts")]
        [Validation(Required=false)]
        public List<UpdateListenerRequestBackendPorts> BackendPorts { get; set; }
        public class UpdateListenerRequestBackendPorts : TeaModel {
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<UpdateListenerRequestCertificates> Certificates { get; set; }
        public class UpdateListenerRequestCertificates : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("ClientAffinity")]
        [Validation(Required=false)]
        public string ClientAffinity { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<UpdateListenerRequestPortRanges> PortRanges { get; set; }
        public class UpdateListenerRequestPortRanges : TeaModel {
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("ProxyProtocol")]
        [Validation(Required=false)]
        public string ProxyProtocol { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public UpdateListenerRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class UpdateListenerRequestXForwardedForConfig : TeaModel {
            [NameInMap("XForwardedForGaApEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaApEnabled { get; set; }

            [NameInMap("XForwardedForGaIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaIdEnabled { get; set; }

            [NameInMap("XForwardedForPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForPortEnabled { get; set; }

            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            [NameInMap("XRealIpEnabled")]
            [Validation(Required=false)]
            public bool? XRealIpEnabled { get; set; }

        }

    }

}
