// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class DescribeCdnDomainResponseBody : TeaModel {
        [NameInMap("AuthConfig")]
        [Validation(Required=false)]
        public DescribeCdnDomainResponseBodyAuthConfig AuthConfig { get; set; }
        public class DescribeCdnDomainResponseBodyAuthConfig : TeaModel {
            [NameInMap("AuthDelta")]
            [Validation(Required=false)]
            public int? AuthDelta { get; set; }

            [NameInMap("AuthKey")]
            [Validation(Required=false)]
            public string AuthKey { get; set; }

            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            [NameInMap("configId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

        }

        [NameInMap("CorsConfig")]
        [Validation(Required=false)]
        public DescribeCdnDomainResponseBodyCorsConfig CorsConfig { get; set; }
        public class DescribeCdnDomainResponseBodyCorsConfig : TeaModel {
            [NameInMap("AccessOriginControl")]
            [Validation(Required=false)]
            public bool? AccessOriginControl { get; set; }

            [NameInMap("AllowOrigin")]
            [Validation(Required=false)]
            public string AllowOrigin { get; set; }

            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

        }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("IpConfig")]
        [Validation(Required=false)]
        public DescribeCdnDomainResponseBodyIpConfig IpConfig { get; set; }
        public class DescribeCdnDomainResponseBodyIpConfig : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            [NameInMap("IpList")]
            [Validation(Required=false)]
            public string IpList { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RefererConfig")]
        [Validation(Required=false)]
        public DescribeCdnDomainResponseBodyRefererConfig RefererConfig { get; set; }
        public class DescribeCdnDomainResponseBodyRefererConfig : TeaModel {
            [NameInMap("AllowEmpty")]
            [Validation(Required=false)]
            public string AllowEmpty { get; set; }

            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            [NameInMap("DisableAst")]
            [Validation(Required=false)]
            public string DisableAst { get; set; }

            [NameInMap("ReferList")]
            [Validation(Required=false)]
            public string ReferList { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("UaConfig")]
        [Validation(Required=false)]
        public DescribeCdnDomainResponseBodyUaConfig UaConfig { get; set; }
        public class DescribeCdnDomainResponseBodyUaConfig : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UaList")]
            [Validation(Required=false)]
            public string UaList { get; set; }

        }

    }

}
