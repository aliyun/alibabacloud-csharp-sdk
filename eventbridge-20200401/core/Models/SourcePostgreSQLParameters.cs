// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SourcePostgreSQLParameters : TeaModel {
        /// <summary>
        /// <para>The name of the PostgreSQL database to connect to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>analytics_db</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The hostname or IP address of the PostgreSQL database server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1xxxxx.pg.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The network type used to connect to the PostgreSQL data source. Valid values: PublicNetwork (public network) and PrivateNetwork (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrivateNetwork</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The password of the database connection user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your_password</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The connection port of the PostgreSQL database server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5432</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The ID of the region where the PostgreSQL data source resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the PostgreSQL schema to synchronize.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_schema</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The ID of the security group used to connect to the PostgreSQL instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-a1b2c3d4e5f6g7h8i9j0</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The snapshot mode used when PostgreSQL data synchronization is started for the first time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>when_needed</para>
        /// </summary>
        [NameInMap("SnapshotMode")]
        [Validation(Required=false)]
        public string SnapshotMode { get; set; }

        /// <summary>
        /// <para>The names of the PostgreSQL tables to synchronize. Separate multiple table names with commas. Each table name must be in the {SchemaName}.{TableName} format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_schema.test_table</para>
        /// </summary>
        [NameInMap("TableNames")]
        [Validation(Required=false)]
        public string TableNames { get; set; }

        /// <summary>
        /// <para>The username for the database connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>readonly_user</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[vsw-a1b2c3d4e5f6g7h8i9j0k]</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        /// <summary>
        /// <para>The ID of the VPC where the PostgreSQL instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-a1b2c3d4e5f6g7h8i9j0k</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
