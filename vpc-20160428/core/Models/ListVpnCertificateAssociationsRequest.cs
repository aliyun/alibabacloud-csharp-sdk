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
        /// <para>You can query the association between at most 20 SSL certificates and VPN gateways.</para>
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
        /// <para>The number of entries to return on each page. Valid values: <b>1</b> to <b>20</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request.</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of <b>NextToken</b>.</description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of VPN gateway IDs.</para>
        /// <para>You can query the association between at most 20 VPN gateways and SSL certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1q8bgx4xnkm****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public List<string> VpnGatewayId { get; set; }

    }

}
