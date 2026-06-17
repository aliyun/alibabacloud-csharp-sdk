// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterMigrationRequest : TeaModel {
        /// <summary>
        /// <para>The specific endpoints to be switched. The value is a JSON string that specifies the endpoints to be swapped.</para>
        /// <remarks>
        /// <para>This parameter is valid only when SwapConnectionString is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;rm-2ze73el581cs*****.mysql.pre.rds.aliyuncs.com&quot;:&quot;pc-2ze8200s298e*****.mysql.polardb.pre.rds.aliyuncs.com&quot;,&quot;rm-2ze73el581cs86*****.mysql.pre.rds.aliyuncs.com&quot;:&quot;test-p*****.mysql.polardb.pre.rds.aliyuncs.com&quot;}</para>
        /// </summary>
        [NameInMap("ConnectionStrings")]
        [Validation(Required=false)]
        public string ConnectionStrings { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the new instance or cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Before the switch, enter the PolarDB cluster ID to perform a switch.</para>
        /// </description></item>
        /// <item><description><para>After the switch, enter the RDS instance ID to perform a rollback.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("NewMasterInstanceId")]
        [Validation(Required=false)]
        public string NewMasterInstanceId { get; set; }

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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The ID of the source RDS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-************</para>
        /// </summary>
        [NameInMap("SourceRDSDBInstanceId")]
        [Validation(Required=false)]
        public string SourceRDSDBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to switch the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Switches the endpoint. The application can connect to the database without changing its connection configuration.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Does not switch the endpoint. The application must be changed to use the new PolarDB endpoint.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SwapConnectionString")]
        [Validation(Required=false)]
        public string SwapConnectionString { get; set; }

    }

}
