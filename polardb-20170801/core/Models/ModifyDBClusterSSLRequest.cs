// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterSSLRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required for a PolarDB for MySQL cluster.</para>
        /// </description></item>
        /// <item><description><para>This parameter is not required for a PolarDB for Oracle or PolarDB for PostgreSQL cluster. By default, SSL encryption is enabled for all endpoints.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/153414.html">DescribeDBClusterSSL</a> operation to view the details of the endpoint.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pe-******************</para>
        /// </summary>
        [NameInMap("DBEndpointId")]
        [Validation(Required=false)]
        public string DBEndpointId { get; set; }

        /// <summary>
        /// <para>The network type supported by the endpoint that is specified by <b>DBEndpointId</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Public</b></description></item>
        /// <item><description><b>Private</b></description></item>
        /// <item><description><b>Inner</b></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required for a PolarDB for MySQL cluster.</para>
        /// </description></item>
        /// <item><description><para>This parameter is not required for a PolarDB for Oracle or PolarDB for PostgreSQL cluster. By default, SSL encryption is enabled for all endpoints.</para>
        /// </description></item>
        /// </list>
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether automatic rotation of SSL certificates is enabled.</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: The feature is enabled.</description></item>
        /// <item><description><b>Disable</b>: The feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("SSLAutoRotate")]
        [Validation(Required=false)]
        public string SSLAutoRotate { get; set; }

        /// <summary>
        /// <para>The SSL encryption status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Disable</b>: SSL encryption is disabled.</description></item>
        /// <item><description><b>Enable</b>: SSL encryption is enabled.</description></item>
        /// <item><description><b>Update</b>: The SSL certificate is updated.</description></item>
        /// </list>
        /// <remarks>
        /// <para>After you enable SSL encryption or update the SSL certificate, you must download and configure the certificate. For more information, see <a href="https://help.aliyun.com/document_detail/153182.html">Configure SSL encryption</a>.</para>
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
