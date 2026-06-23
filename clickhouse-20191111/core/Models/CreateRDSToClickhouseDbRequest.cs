// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CreateRDSToClickhouseDbRequest : TeaModel {
        /// <summary>
        /// <para>The password for the database account of the ApsaraDB for ClickHouse cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456Aa</para>
        /// </summary>
        [NameInMap("CkPassword")]
        [Validation(Required=false)]
        public string CkPassword { get; set; }

        /// <summary>
        /// <para>The database account of the ApsaraDB for ClickHouse cluster.</para>
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
        /// <para>cc-2ze5zeyl72188****</para>
        /// </summary>
        [NameInMap("DbClusterId")]
        [Validation(Required=false)]
        public string DbClusterId { get; set; }

        /// <summary>
        /// <para>The maximum number of rows to sync per second.</para>
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
        /// <para>rm-8vb989qj9roh0****</para>
        /// </summary>
        [NameInMap("RdsId")]
        [Validation(Required=false)]
        public string RdsId { get; set; }

        /// <summary>
        /// <para>The password for the database account of the ApsaraDB RDS for MySQL instance.</para>
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
        /// <para>The database account of the ApsaraDB RDS for MySQL instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user2</para>
        /// </summary>
        [NameInMap("RdsUserName")]
        [Validation(Required=false)]
        public string RdsUserName { get; set; }

        /// <summary>
        /// <para>The VPC ID of the ApsaraDB RDS for MySQL instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zen93xryil99jsfy****</para>
        /// </summary>
        [NameInMap("RdsVpcId")]
        [Validation(Required=false)]
        public string RdsVpcId { get; set; }

        /// <summary>
        /// <para>The internal endpoint of the ApsaraDB RDS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp16t9h3999xb0a7****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("RdsVpcUrl")]
        [Validation(Required=false)]
        public string RdsVpcUrl { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip unsupported table schemas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Skip.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not skip.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SkipUnsupported")]
        [Validation(Required=false)]
        public bool? SkipUnsupported { get; set; }

        /// <summary>
        /// <para>The tables to sync.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Schema&quot;:&quot;recommend&quot;,&quot;Tables&quot;:[&quot;mr_platform_cpm&quot;,&quot;mr_platform_ecpm&quot;,&quot;p_monitor_record&quot;]}]</para>
        /// </summary>
        [NameInMap("SynDbTables")]
        [Validation(Required=false)]
        public string SynDbTables { get; set; }

    }

}
