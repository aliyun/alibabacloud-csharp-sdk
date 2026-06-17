// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBEndpointAddressRequest : TeaModel {
        /// <summary>
        /// <para>The new connection string prefix. The prefix must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>It can contain only lowercase letters, digits, and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>It must start with a letter and end with a letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>It must be 6 to 30 characters in length.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of all clusters in your account, including cluster IDs.</para>
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
        /// <para>The ID of the connection address.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98205.html">DescribeDBClusterEndpoints</a> operation to query the ID of a connection address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pe-****************</para>
        /// </summary>
        [NameInMap("DBEndpointId")]
        [Validation(Required=false)]
        public string DBEndpointId { get; set; }

        /// <summary>
        /// <para>The network type of the connection address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Public</b>: public network</para>
        /// </description></item>
        /// <item><description><para><b>Private</b>: private network</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>Inner</b>: classic network</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>Only PolarDB for MySQL clusters support the classic network type.</para>
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
        /// <para>The port number. The valid range is 3000 to 5999.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is supported only for PolarDB for MySQL clusters. If you do not specify this parameter, the port defaults to 3306.</description></item>
        /// </list>
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
        /// <item><description><para>It can contain only lowercase letters, digits, and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>It must start with a letter and end with a letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>It must be 6 to 30 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can bind a private domain name to each private endpoint of a PolarDB cluster. This domain name is effective only in the specified VPC within the current region. The private domain name is managed by PrivateZone and is mapped to the built-in private endpoint of the cluster through a CNAME record. This feature incurs a small fee. For more information, see <a href="https://help.aliyun.com/document_detail/71338.html">Pricing</a>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is valid only when <b>NetType is set to Private</b>.</para>
        /// </description></item>
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
        /// <para>The private zone name.</para>
        /// <remarks>
        /// <para>This parameter is valid only when <b>NetType is set to Private</b>.</para>
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
