// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpnCertificateAssociationsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If **NextToken** is not empty, the value indicates the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The association information.
        /// </summary>
        [NameInMap("VpnCertificateRelations")]
        [Validation(Required=false)]
        public List<ListVpnCertificateAssociationsResponseBodyVpnCertificateRelations> VpnCertificateRelations { get; set; }
        public class ListVpnCertificateAssociationsResponseBodyVpnCertificateRelations : TeaModel {
            /// <summary>
            /// The time when the Anycast EIP was associated.
            /// 
            /// The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("AssociationTime")]
            [Validation(Required=false)]
            public string AssociationTime { get; set; }

            /// <summary>
            /// The certificate ID.
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            /// <summary>
            /// The type of the certificate.
            /// 
            /// *   **Encryption**
            /// *   **Signature**
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            /// <summary>
            /// The ID of the region where the VPN gateway is created.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the VPN gateway.
            /// </summary>
            [NameInMap("VpnGatewayId")]
            [Validation(Required=false)]
            public string VpnGatewayId { get; set; }

        }

    }

}
