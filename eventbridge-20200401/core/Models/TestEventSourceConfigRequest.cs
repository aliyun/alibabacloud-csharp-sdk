// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class TestEventSourceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The parameters that are configured if you specify MySQL as the event source.</para>
        /// </summary>
        [NameInMap("SourceMySQLParameters")]
        [Validation(Required=false)]
        public TestEventSourceConfigRequestSourceMySQLParameters SourceMySQLParameters { get; set; }
        public class TestEventSourceConfigRequestSourceMySQLParameters : TeaModel {
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
            /// <para>The endpoint of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1vxxx.mysql.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The network type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PrivateNetwork</description></item>
            /// <item><description>PublicNetwork</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrivateNetwork</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The password that is used for authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234xxx</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The port that is used to connect to the database.</para>
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
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-xxx</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The table name. The name must be prefixed with the database name. ${DatabaseName}.${TableName}</para>
            /// 
            /// <b>Example:</b>
            /// <para>database1.table1</para>
            /// </summary>
            [NameInMap("TableNames")]
            [Validation(Required=false)]
            public string TableNames { get; set; }

            /// <summary>
            /// <para>The username that is used to log on to the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user***</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1gb7xxx</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public string VSwitchIds { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) ID.</para>
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
