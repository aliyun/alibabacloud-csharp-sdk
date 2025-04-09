// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyEndpointAddressRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4n3a****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The network type of the database proxy endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Public</b></description></item>
        /// <item><description><b>VPC</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the RDS instance runs MySQL, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("DBProxyConnectStringNetType")]
        [Validation(Required=false)]
        public string DBProxyConnectStringNetType { get; set; }

        /// <summary>
        /// <para>The ID of the database proxy endpoint. You can call the DescribeDBProxyEndpoint operation to query the ID of the database proxy endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ta9um4****</para>
        /// </summary>
        [NameInMap("DBProxyEndpointId")]
        [Validation(Required=false)]
        public string DBProxyEndpointId { get; set; }

        /// <summary>
        /// <para>A deprecated parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// <para>The prefix of the new database proxy endpoint. A custom value is supported.</para>
        /// <remarks>
        /// <para> You must specify at least one of the <b>DBProxyNewConnectString</b> and <b>DBProxyNewConnectStringPort</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test123456</para>
        /// </summary>
        [NameInMap("DBProxyNewConnectString")]
        [Validation(Required=false)]
        public string DBProxyNewConnectString { get; set; }

        /// <summary>
        /// <para>The port number that is associated with the database proxy endpoint. A custom value is supported.</para>
        /// <remarks>
        /// <para> You must specify at least one of the <b>DBProxyNewConnectString</b> and <b>DBProxyNewConnectStringPort</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3307</para>
        /// </summary>
        [NameInMap("DBProxyNewConnectStringPort")]
        [Validation(Required=false)]
        public string DBProxyNewConnectStringPort { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
