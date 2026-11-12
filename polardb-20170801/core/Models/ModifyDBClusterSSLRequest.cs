// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterSSLRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the SSL certificate. Unit: days. Valid values: 365 and 1095.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1095</para>
        /// </summary>
        [NameInMap("CertValidDays")]
        [Validation(Required=false)]
        public string CertValidDays { get; set; }

        /// <summary>
        /// <para>The connection string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.cluster.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The endpoint ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required if the target cluster is a PolarDB for MySQL cluster.</description></item>
        /// <item><description>This parameter is not required if the target cluster is a PolarDB for PostgreSQL cluster or a PolarDB for PostgreSQL (Compatible with Oracle) cluster. By default, Secure Sockets Layer (SSL) encryption is enabled for all endpoints.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/2319159.html">DescribeDBClusterSSL</a> operation to query endpoint details.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pe-******************</para>
        /// </summary>
        [NameInMap("DBEndpointId")]
        [Validation(Required=false)]
        public string DBEndpointId { get; set; }

        /// <summary>
        /// <para>The network type of the endpoint. The value must be the same as the network type of the endpoint specified by the <b>DBEndpointId</b> parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Public</b>: Internet</description></item>
        /// <item><description><b>Private</b>: Private network</description></item>
        /// <item><description><b>Inner</b>: Private network (classic network)</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required if the target cluster is a PolarDB for MySQL cluster.</description></item>
        /// <item><description>This parameter is not required if the target cluster is a PolarDB for PostgreSQL cluster or a PolarDB for PostgreSQL (Compatible with Oracle) cluster. By default, Secure Sockets Layer (SSL) encryption is enabled for all endpoints.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>The PFS instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-xxx</para>
        /// </summary>
        [NameInMap("PfsInstanceId")]
        [Validation(Required=false)]
        public string PfsInstanceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic rotation for SSL certificates. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enable</b>: Enables automatic rotation.</para>
        /// </description></item>
        /// <item><description><para><b>Disable</b>: Disables automatic rotation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("SSLAutoRotate")]
        [Validation(Required=false)]
        public string SSLAutoRotate { get; set; }

        /// <summary>
        /// <para>Modifies the Secure Sockets Layer (SSL) encryption status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Disable</b>: Performs a shutdown of Secure Sockets Layer (SSL) encryption.</description></item>
        /// <item><description><b>Enable</b>: Enables Secure Sockets Layer (SSL) encryption.</description></item>
        /// <item><description><b>Update</b>: Updates the CA certificate.</description></item>
        /// </list>
        /// <remarks>
        /// <para>After you enable Secure Sockets Layer (SSL) encryption or update the CA certificate, you must download and configure the certificate. For details, see <a href="https://help.aliyun.com/document_detail/153182.html">Configure SSL encryption</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public string SSLEnabled { get; set; }

    }

}
