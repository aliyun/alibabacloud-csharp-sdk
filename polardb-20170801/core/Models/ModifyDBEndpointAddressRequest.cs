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
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of all clusters under your account, including the cluster ID.</para>
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
        /// <para>The endpoint ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98205.html">DescribeDBClusterEndpoints</a> operation to query the endpoint ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pe-****************</para>
        /// </summary>
        [NameInMap("DBEndpointId")]
        [Validation(Required=false)]
        public string DBEndpointId { get; set; }

        /// <summary>
        /// <para>The network type of the endpoint. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Public</b>: Internet</description></item>
        /// <item><description><b>Private</b>: Private network
        /// &lt;props=&quot;china&quot;&gt;- <b>Inner</b>: Classic network</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;Only PolarDB for MySQL clusters support the classic network type.</para>
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
        /// <list type="bullet">
        /// <item><description>Only PolarDB for MySQL clusters support this parameter. If this parameter is left empty, the default port number is 3306.</description></item>
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
        /// <item><description>It can contain lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>It must start with a letter and end with a digit or a letter.</description></item>
        /// <item><description>It must be 6 to 30 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can bind a private domain name to each private endpoint of PolarDB. The domain name takes effect only in the specified VPC within the current region. The private domain name is managed by PrivateZone and mapped to the built-in private endpoint of PolarDB through a CNAME record. PrivateZone charges a small fee for this feature. For more information, see <a href="https://help.aliyun.com/document_detail/71338.html">Pricing</a>.</description></item>
        /// <item><description>This parameter is valid only when <b>NetType</b> is set to <b>Private</b>.</description></item>
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
        /// <para>The zone name of the private domain name.</para>
        /// <remarks>
        /// <para>This parameter is valid only when <b>NetType</b> is set to <b>Private</b>.</para>
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
