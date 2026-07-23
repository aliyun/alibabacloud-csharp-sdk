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
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The hostname or IP address of the database server.</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>Indicates whether to include schema changes.</para>
        /// </summary>
        [NameInMap("IncludeSchemaChanges")]
        [Validation(Required=false)]
        public string IncludeSchemaChanges { get; set; }

        /// <summary>
        /// <para>The network type.</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The password for the user.</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The database server port.</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The ID of the region that contains the data source.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the security group.</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The snapshot mode.</para>
        /// </summary>
        [NameInMap("SnapshotMode")]
        [Validation(Required=false)]
        public string SnapshotMode { get; set; }

        /// <summary>
        /// <para>The names of tables to synchronize. Separate multiple table names with a comma.</para>
        /// </summary>
        [NameInMap("TableNames")]
        [Validation(Required=false)]
        public string TableNames { get; set; }

        /// <summary>
        /// <para>The database username.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// <para>The VSwitch IDs. Separate multiple IDs with a comma.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
