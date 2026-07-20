// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The certification authority (CA) brand. Valid values: WoSign, CFCA, DigiCert, GeoTrust, GlobalSign, vTrus, and Alibaba.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Digicert</para>
        /// </summary>
        [NameInMap("Brand")]
        [Validation(Required=false)]
        public string Brand { get; set; }

        /// <summary>
        /// <para>The status of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>issued</b>: Issued.</description></item>
        /// <item><description><b>revoked</b>: Revoked.</description></item>
        /// <item><description><b>willExpire</b>: About to expire.</description></item>
        /// <item><description><b>expired</b>: Expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>issued</para>
        /// </summary>
        [NameInMap("CertificateStatus")]
        [Validation(Required=false)]
        public string CertificateStatus { get; set; }

        /// <summary>
        /// <para>The type of the certificate. Valid values: DV, OV, and EV.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DV</para>
        /// </summary>
        [NameInMap("CertificateType")]
        [Validation(Required=false)]
        public string CertificateType { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BUY: official certificate.</description></item>
        /// <item><description>TEST: test certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The keyword for fuzzy match. Matches domain names, instance names, or corresponding resource IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ae******4wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The number of instances to display per page in a paged query. Default value: <b>10</b>. Maximum value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>inactive</b>: pending use.</description></item>
        /// <item><description><b>pending</b>: under review. The latest certificate is being reviewed.</description></item>
        /// <item><description><b>willExpire</b>: about to expire.</description></item>
        /// <item><description><b>expired</b>: expired.</description></item>
        /// <item><description><b>refund</b>: refunded.</description></item>
        /// <item><description><b>normal</b>: normal.</description></item>
        /// <item><description><b>closed</b>: closed and unavailable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>inactive</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
