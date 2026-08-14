// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpnCertificateAssociationsRequest : TeaModel {
        /// <summary>
        /// <para>The list of certificate IDs.</para>
        /// <para>You can query the associations between up to 20 SSL certificates and VPN gateway instances at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6bfe4218-ea1d****</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public List<string> CertificateId { get; set; }

        /// <summary>
        /// <para>The certificate type. Valid values:</para>
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
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>20</b>. Default value: <b>10</b>.</para>
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
        /// <item><description><para>If this is the first query or no subsequent query exists, leave this parameter empty.</para>
        /// </description></item>
        /// <item><description><para>If a subsequent query exists, set this parameter to the <b>NextToken</b> value returned by the previous API call.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be0****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID of the VPN gateway.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of VPN gateway instance IDs.</para>
        /// <para>You can query the associations between up to 20 VPN gateway instances and SSL certificates at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1q8bgx4xnkm****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public List<string> VpnGatewayId { get; set; }

    }

}
