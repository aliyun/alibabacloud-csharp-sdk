// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpnCertificateAssociationsRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("CertificateType")]
        [Validation(Required=false)]
        public string CertificateType { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public List<string> VpnGatewayId { get; set; }

        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public List<string> CertificateId { get; set; }

        [NameInMap("callerBid")]
        [Validation(Required=false)]
        public string CallerBid { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
