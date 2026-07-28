// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSslVpnClientCertResponseBody : TeaModel {
        /// <summary>
        /// <para>The CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIID****r4w=
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("CaCert")]
        [Validation(Required=false)]
        public string CaCert { get; set; }

        /// <summary>
        /// <para>The client certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIIDR****A==
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("ClientCert")]
        [Validation(Required=false)]
        public string ClientCert { get; set; }

        /// <summary>
        /// <para>The client configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client
        /// dev tun
        /// proto tcp
        /// remote 120.XX.XX.33 1194
        /// resolv-retry infinite
        /// nobind
        /// persist-key
        /// persist-tun
        /// ca ca.crt
        /// cert vsc-bp15t7****.crt
        /// key vsc-bp15t7****.key
        /// cipher AES-128-CBC
        /// ;comp-lzo
        /// verb 4</para>
        /// </summary>
        [NameInMap("ClientConfig")]
        [Validation(Required=false)]
        public string ClientConfig { get; set; }

        /// <summary>
        /// <para>The client key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN RSA PRIVATE KEY-----
        /// MIIEpAI****ZzNFhuM/za==
        /// -----END RSA PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("ClientKey")]
        [Validation(Required=false)]
        public string ClientKey { get; set; }

        /// <summary>
        /// <para>The timestamp when the SSL client certificate was created. Unit: milliseconds.</para>
        /// <para>The timestamp is in the UNIX format and represents the total number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1552550980000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The timestamp when the SSL client certificate expires. Unit: milliseconds.</para>
        /// <para>The timestamp is in the UNIX format and represents the total number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1647158980000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The name of the SSL client certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID of the SSL client certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BE01CD7-5A50-472D-AC14-CA181C5C03BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID of the SSL client certificate.</para>
        /// <para>The SSL client certificate belongs to the same resource group as its associated SSL server. You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource group information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzs372yg****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the SSL client certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsc-bp13k5mp4tg8v3z9b****</para>
        /// </summary>
        [NameInMap("SslVpnClientCertId")]
        [Validation(Required=false)]
        public string SslVpnClientCertId { get; set; }

        /// <summary>
        /// <para>The ID of the SSL server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vss-bp155e9yclsg1xgq4****</para>
        /// </summary>
        [NameInMap("SslVpnServerId")]
        [Validation(Required=false)]
        public string SslVpnServerId { get; set; }

        /// <summary>
        /// <para>The status of the SSL client certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>expiring-soon</b>: The certificate will expire within one week.</para>
        /// </description></item>
        /// <item><description><para><b>normal</b>: Normal. </para>
        /// </description></item>
        /// <item><description><para><b>expired</b>: Expired.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
