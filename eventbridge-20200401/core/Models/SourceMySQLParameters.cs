// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SourceMySQLParameters : TeaModel {
        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>database1</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The hostname or IP address of the database server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1vxxx.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>Indicates whether to include schema changes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeSchemaChanges")]
        [Validation(Required=false)]
        public string IncludeSchemaChanges { get; set; }

        /// <summary>
        /// <para>The network type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrivateNetwork</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The password for the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The database server port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The ID of the region that contains the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-a1b2c3d4e5f6g7h8i9j0</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The snapshot mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>when_needed</para>
        /// </summary>
        [NameInMap("SnapshotMode")]
        [Validation(Required=false)]
        public string SnapshotMode { get; set; }

        /// <summary>
        /// <para>The names of tables to synchronize. Separate multiple table names with a comma.</para>
        /// 
        /// <b>Example:</b>
        /// <para>database1.table1</para>
        /// </summary>
        [NameInMap("TableNames")]
        [Validation(Required=false)]
        public string TableNames { get; set; }

        /// <summary>
        /// <para>The database username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example_user</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// <para>The VSwitch IDs. Separate multiple IDs with a comma.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[vsw-a1b2c3d4e5f6g7h8i9j0k]</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-a1b2c3d4e5f6g7h8i9j0k</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
