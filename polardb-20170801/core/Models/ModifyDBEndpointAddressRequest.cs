// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBEndpointAddressRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the new endpoint. The prefix must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It can contain lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>It must start with a letter and end with a digit or a letter.</description></item>
        /// <item><description>It must be 6 to 30 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>The ID of cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of the clusters that belong to your Alibaba Cloud account, such as cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-***************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98205.html">DescribeDBClusterEndpoints</a> operation to query endpoint IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pe-****************</para>
        /// </summary>
        [NameInMap("DBEndpointId")]
        [Validation(Required=false)]
        public string DBEndpointId { get; set; }

        /// <summary>
        /// <para>The network type of the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Public</b></description></item>
        /// <item><description><b>Private</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The port number. Valid values: 3000 to 5999.</para>
        /// <remarks>
        /// <para>This parameter is valid only for PolarDB for MySQL clusters. If you leave this parameter empty, the default port 3306 is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The prefix of the private domain name. The prefix must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The prefix can contain lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>The prefix must start with a letter and end with a digit or a letter.</description></item>
        /// <item><description>The prefix must be 6 to 30 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can bind each internal endpoint of PolarDB to a private domain name. The private domain name takes effect only in the specified virtual private clouds (VPCs) in the current region. Private domain names are managed by using PrivateZone. You can use the CNAME record of PrivateZone to map domain names to PolarDB. You are charged a small fee for this feature. For more information, see <a href="https://help.aliyun.com/document_detail/71338.html">Pricing</a>.</description></item>
        /// <item><description>This parameter takes effect only if you set <b>NetType</b> to Private.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aliyundoc</para>
        /// </summary>
        [NameInMap("PrivateZoneAddressPrefix")]
        [Validation(Required=false)]
        public string PrivateZoneAddressPrefix { get; set; }

        /// <summary>
        /// <para>The name of the private zone.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>NetType</b> is set to Private.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aliyundoc.com</para>
        /// </summary>
        [NameInMap("PrivateZoneName")]
        [Validation(Required=false)]
        public string PrivateZoneName { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
