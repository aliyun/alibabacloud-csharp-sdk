// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ImportServicesRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        [NameInMap("ServiceList")]
        [Validation(Required=false)]
        public List<ImportServicesRequestServiceList> ServiceList { get; set; }
        public class ImportServicesRequestServiceList : TeaModel {
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("Ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public long? ServicePort { get; set; }

            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }

        }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("TlsSetting")]
        [Validation(Required=false)]
        public string TlsSetting { get; set; }

    }

}
