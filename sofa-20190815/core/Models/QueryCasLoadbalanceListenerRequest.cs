// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasLoadbalanceListenerRequest : TeaModel {
        [NameInMap("BackendServerPortsRepeatList")]
        [Validation(Required=false)]
        public List<long?> BackendServerPortsRepeatList { get; set; }

        [NameInMap("CertificateIaasIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> CertificateIaasIdsRepeatList { get; set; }

        [NameInMap("CertificateIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> CertificateIdsRepeatList { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("GmCryptoCertIaasIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> GmCryptoCertIaasIdsRepeatList { get; set; }

        [NameInMap("GmSignCertIaasIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> GmSignCertIaasIdsRepeatList { get; set; }

        [NameInMap("ListenerPortsRepeatList")]
        [Validation(Required=false)]
        public List<long?> ListenerPortsRepeatList { get; set; }

        [NameInMap("LoadBalancerIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> LoadBalancerIdsRepeatList { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TypesRepeatList")]
        [Validation(Required=false)]
        public List<string> TypesRepeatList { get; set; }

        [NameInMap("VComputerGroupIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> VComputerGroupIdsRepeatList { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
