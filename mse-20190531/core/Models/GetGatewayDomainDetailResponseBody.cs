// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayDomainDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayDomainDetailResponseBodyData Data { get; set; }
        public class GetGatewayDomainDetailResponseBodyData : TeaModel {
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public int? CertIdentifier { get; set; }
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }
            [NameInMap("GmtAfter")]
            [Validation(Required=false)]
            public string GmtAfter { get; set; }
            [NameInMap("GmtBefore")]
            [Validation(Required=false)]
            public string GmtBefore { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }
            [NameInMap("MustHttps")]
            [Validation(Required=false)]
            public bool? MustHttps { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
