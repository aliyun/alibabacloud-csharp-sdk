// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpnCertificateAssociationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>NextToken</b> is empty, no subsequent query exists.</para>
        /// </description></item>
        /// <item><description><para>If <b>NextToken</b> is returned, the value indicates the token for the next query.</para>
        /// </description></item>
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
        /// <para>The total number of associations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of associations.</para>
        /// </summary>
        [NameInMap("VpnCertificateRelations")]
        [Validation(Required=false)]
        public List<ListVpnCertificateAssociationsResponseBodyVpnCertificateRelations> VpnCertificateRelations { get; set; }
        public class ListVpnCertificateAssociationsResponseBodyVpnCertificateRelations : TeaModel {
            /// <summary>
            /// <para>The time when the association was created.</para>
            /// <para>The time is displayed in UTC in the YYYY-MM-DDThh:mm:ssZ format.</para>
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
            /// <para>The certificate type.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Encryption</b>: encryption certificate.</para>
            /// </description></item>
            /// <item><description><para><b>Signature</b>: signing certificate.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Signature</para>
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            /// <summary>
            /// <para>The region ID of the VPN gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The VPN gateway instance ID.</para>
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
