// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyRDSToClickhouseDbRequest : TeaModel {
        /// <summary>
        /// <para>The password of the account that is used to log on to the database in the ApsaraDB for ClickHouse cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456Aa</para>
        /// </summary>
        [NameInMap("CkPassword")]
        [Validation(Required=false)]
        public string CkPassword { get; set; }

        /// <summary>
        /// <para>The account that is used to log on to the database in the ApsaraDB for ClickHouse cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("CkUserName")]
        [Validation(Required=false)]
        public string CkUserName { get; set; }

        /// <summary>
        /// <para>The port number of the ApsaraDB for ClickHouse cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8123</para>
        /// </summary>
        [NameInMap("ClickhousePort")]
        [Validation(Required=false)]
        public long? ClickhousePort { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraDB for ClickHouse cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp158i5wvj436****</para>
        /// </summary>
        [NameInMap("DbClusterId")]
        [Validation(Required=false)]
        public string DbClusterId { get; set; }

        /// <summary>
        /// <para>The maximum number of rows that can be synchronized per second.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50000</para>
        /// </summary>
        [NameInMap("LimitUpper")]
        [Validation(Required=false)]
        public long? LimitUpper { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraDB RDS for MySQL instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6x3qq4t90ok****</para>
        /// </summary>
        [NameInMap("RdsId")]
        [Validation(Required=false)]
        public string RdsId { get; set; }

        /// <summary>
        /// <para>The password of the account that is used to log on to the database in the ApsaraDB RDS for MySQL instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456Rr</para>
        /// </summary>
        [NameInMap("RdsPassword")]
        [Validation(Required=false)]
        public string RdsPassword { get; set; }

        /// <summary>
        /// <para>The port number of the ApsaraDB RDS for MySQL instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("RdsPort")]
        [Validation(Required=false)]
        public long? RdsPort { get; set; }

        /// <summary>
        /// <para>The database in the ApsaraDB RDS for MySQL instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>database</para>
        /// </summary>
        [NameInMap("RdsSynDb")]
        [Validation(Required=false)]
        public string RdsSynDb { get; set; }

        /// <summary>
        /// <para>The table in the ApsaraDB RDS for MySQL instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table</para>
        /// </summary>
        [NameInMap("RdsSynTables")]
        [Validation(Required=false)]
        public string RdsSynTables { get; set; }

        /// <summary>
        /// <para>The account that is used to log on to the database in the ApsaraDB RDS for MySQL instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user2</para>
        /// </summary>
        [NameInMap("RdsUserName")]
        [Validation(Required=false)]
        public string RdsUserName { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the ApsaraDB RDS for MySQL instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1v9dtwmqqjhwwg****</para>
        /// </summary>
        [NameInMap("RdsVpcId")]
        [Validation(Required=false)]
        public string RdsVpcId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore databases that do not support synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SkipUnsupported")]
        [Validation(Required=false)]
        public bool? SkipUnsupported { get; set; }

    }

}
