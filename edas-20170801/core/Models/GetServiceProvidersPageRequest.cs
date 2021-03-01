// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceProvidersPageRequest : TeaModel {
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("serviceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        [NameInMap("group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        [NameInMap("ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("registryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
