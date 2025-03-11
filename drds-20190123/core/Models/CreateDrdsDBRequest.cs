// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CreateDrdsDBRequest : TeaModel {
        /// <summary>
        /// <para>The name of the account that has permissions to access all databases on the ApsaraDB RDS for MySQL instance.</para>
        /// <para>This parameter is required only when the Type parameter is set to VERTICAL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds_sample_account</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The type of the storage instances that are used by the PolarDB-X 1.0 database. Set the value to RDS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("DbInstType")]
        [Validation(Required=false)]
        public string DbInstType { get; set; }

        /// <summary>
        /// <para>Specifies whether the required ApsaraDB RDS for MySQL instance is being created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DbInstanceIsCreating")]
        [Validation(Required=false)]
        public bool? DbInstanceIsCreating { get; set; }

        /// <summary>
        /// <para>The name of the PolarDB-X 1.0 database you want to create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB-X 1.0 instance on which you want to create the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drdshbgal154****</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>The encoding method that is used by the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>utf8</para>
        /// </summary>
        [NameInMap("Encode")]
        [Validation(Required=false)]
        public string Encode { get; set; }

        [NameInMap("InstDbName")]
        [Validation(Required=false)]
        public List<CreateDrdsDBRequestInstDbName> InstDbName { get; set; }
        public class CreateDrdsDBRequestInstDbName : TeaModel {
            /// <summary>
            /// <para>The ID of the ApsaraDB RDS for MySQL instance on which the databases need to be vertically partitioned. This parameter is required only when the Type parameter is set to VERTICAL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drds_sample_rds_id</para>
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;drds_sample_db1&quot;, &quot;drds_sample_db2&quot;]</para>
            /// </summary>
            [NameInMap("ShardDbName")]
            [Validation(Required=false)]
            public List<string> ShardDbName { get; set; }

        }

        /// <summary>
        /// <para>The password that is used to log on to the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds_sample_password</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;drds_sample_rds_id1&quot;, &quot;drds_sample_rds_id2&quot;]</para>
        /// </summary>
        [NameInMap("RdsInstance")]
        [Validation(Required=false)]
        public List<string> RdsInstance { get; set; }

        [NameInMap("RdsSuperAccount")]
        [Validation(Required=false)]
        public List<CreateDrdsDBRequestRdsSuperAccount> RdsSuperAccount { get; set; }
        public class CreateDrdsDBRequestRdsSuperAccount : TeaModel {
            /// <summary>
            /// <para>The account name of the super administrator that is used to connect to the ApsaraDB RDS for MySQL instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drds_sample_rds_super_account</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The ID of ApsaraDB RDS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drds_sample_rds_id</para>
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            /// <summary>
            /// <para>The password of the super administrator account that is used to connect to the ApsaraDB RDS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drds_sample_rds_super_password</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

        /// <summary>
        /// <para>The partitioning mode of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HORIZONTAL</b>: The database is horizontally partitioned (sharded).</description></item>
        /// <item><description><b>VERTICAL</b>: The database is vertically partitioned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HORIZONTAL</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
