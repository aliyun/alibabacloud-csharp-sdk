// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterMigrationRequest : TeaModel {
        /// <summary>
        /// <para>The endpoints to be switched. The endpoints are in the JSON format.</para>
        /// <remarks>
        /// <para>This parameter is valid when the SwapConnectionString parameter is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;rm-2ze73el581cs*****.mysql.pre.rds.aliyuncs.com&quot;:&quot;pc-2ze8200s298e*****.mysql.polardb.pre.rds.aliyuncs.com&quot;,&quot;rm-2ze73el581cs86*****.mysql.pre.rds.aliyuncs.com&quot;:&quot;test-p*****.mysql.polardb.pre.rds.aliyuncs.com&quot;}</para>
        /// </summary>
        [NameInMap("ConnectionStrings")]
        [Validation(Required=false)]
        public string ConnectionStrings { get; set; }

        /// <summary>
        /// <para>The ID of cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the new instance or new cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>To perform a data migration, enter the ID of the PolarDB cluster.</description></item>
        /// <item><description>To perform a migration rollback, enter the ID of the ApsaraDB for RDS instance.</description></item>
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
        /// <para>The ID of the source ApsaraDB RDS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-************</para>
        /// </summary>
        [NameInMap("SourceRDSDBInstanceId")]
        [Validation(Required=false)]
        public string SourceRDSDBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to switch the endpoints. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: switches the endpoints. If you select this option, you do not need the change the endpoint in your applications.</description></item>
        /// <item><description><b>false</b>: does not switch the endpoints. If you select this option, you must specify the endpoint of the PolarDB cluster in your applications.</description></item>
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
