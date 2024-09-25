// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpnCertificateAssociationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If <b>NextToken</b> is not empty, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>197AF2BD-547F-470C-B29A-8400400233EB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The association information.</para>
        /// </summary>
        [NameInMap("VpnCertificateRelations")]
        [Validation(Required=false)]
        public List<ListVpnCertificateAssociationsResponseBodyVpnCertificateRelations> VpnCertificateRelations { get; set; }
        public class ListVpnCertificateAssociationsResponseBodyVpnCertificateRelations : TeaModel {
            /// <summary>
            /// <para>The time when the Anycast EIP was associated.</para>
            /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-29T09:30:29Z</para>
            /// </summary>
            [NameInMap("AssociationTime")]
            [Validation(Required=false)]
            public string AssociationTime { get; set; }

            /// <summary>
            /// <para>The certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6bfe4218-ea1d****</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            /// <summary>
            /// <para>The type of the certificate.</para>
            /// <list type="bullet">
            /// <item><description><b>Encryption</b></description></item>
            /// <item><description><b>Signature</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Signature</para>
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            /// <summary>
            /// <para>The ID of the region where the VPN gateway is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the VPN gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpn-bp1usbiorilk51760****</para>
            /// </summary>
            [NameInMap("VpnGatewayId")]
            [Validation(Required=false)]
            public string VpnGatewayId { get; set; }

        }

    }

}
