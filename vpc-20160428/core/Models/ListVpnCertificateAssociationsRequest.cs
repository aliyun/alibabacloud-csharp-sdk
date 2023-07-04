// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpnCertificateAssociationsRequest : TeaModel {
        /// <summary>
        /// The list of certificate IDs.
        /// 
        /// You can query the association between at most 20 SSL certificates and VPN gateways.
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public List<string> CertificateId { get; set; }

        /// <summary>
        /// The certificate type. Valid values:
        /// 
        /// *   **Encryption**
        /// *   **Signature**
        /// </summary>
        [NameInMap("CertificateType")]
        [Validation(Required=false)]
        public string CertificateType { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **20**. Default value: **1**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   You do not need to specify this parameter for the first request.
        /// *   You must specify the token that is obtained from the previous query as the value of **NextToken**.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID of the VPN gateway.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The list of VPN gateway IDs.
        /// 
        /// You can query the association between at most 20 VPN gateways and SSL certificates.
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public List<string> VpnGatewayId { get; set; }

    }

}
