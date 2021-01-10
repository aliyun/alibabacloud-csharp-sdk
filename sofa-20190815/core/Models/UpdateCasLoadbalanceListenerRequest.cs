// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateCasLoadbalanceListenerRequest : TeaModel {
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        [NameInMap("CertificateIaasId")]
        [Validation(Required=false)]
        public string CertificateIaasId { get; set; }

        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        [NameInMap("Cookie")]
        [Validation(Required=false)]
        public string Cookie { get; set; }

        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public long? CookieTimeout { get; set; }

        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public long? EstablishedTimeout { get; set; }

        [NameInMap("GmCryptoCertIaasId")]
        [Validation(Required=false)]
        public string GmCryptoCertIaasId { get; set; }

        [NameInMap("GmSignCertIaasId")]
        [Validation(Required=false)]
        public string GmSignCertIaasId { get; set; }

        [NameInMap("HealthMonitorJsonStr")]
        [Validation(Required=false)]
        public string HealthMonitorJsonStr { get; set; }

        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public long? ListenerPort { get; set; }

        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("PersistTimeout")]
        [Validation(Required=false)]
        public long? PersistTimeout { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        [NameInMap("StickySessionType")]
        [Validation(Required=false)]
        public string StickySessionType { get; set; }

        [NameInMap("TlsCipherPolicy")]
        [Validation(Required=false)]
        public string TlsCipherPolicy { get; set; }

        [NameInMap("UseVComputerGroup")]
        [Validation(Required=false)]
        public bool? UseVComputerGroup { get; set; }

        [NameInMap("VComputerGroupId")]
        [Validation(Required=false)]
        public string VComputerGroupId { get; set; }

    }

}
