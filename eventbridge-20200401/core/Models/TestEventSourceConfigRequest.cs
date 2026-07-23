// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class TestEventSourceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The parameters for the MySQL source.</para>
        /// </summary>
        [NameInMap("SourceMySQLParameters")]
        [Validation(Required=false)]
        public TestEventSourceConfigRequestSourceMySQLParameters SourceMySQLParameters { get; set; }
        public class TestEventSourceConfigRequestSourceMySQLParameters : TeaModel {
            /// <summary>
            /// <para>The list of allowed CIDR blocks.</para>
            /// </summary>
            [NameInMap("AllowedCIDRs")]
            [Validation(Required=false)]
            public string AllowedCIDRs { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database1</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The database endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1vxxx.mysql.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

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
            /// <para>The password for the specified username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234xxx</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The database connection port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-xxx</para>
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
            /// <para>The table name. The name must be prefixed with the database name in the ${DatabaseName}.${TableName} format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database1.table1</para>
            /// </summary>
            [NameInMap("TableNames")]
            [Validation(Required=false)]
            public string TableNames { get; set; }

            /// <summary>
            /// <para>The username for the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user***</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// <para>The vSwitch IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1gb7xxx</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public string VSwitchIds { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
