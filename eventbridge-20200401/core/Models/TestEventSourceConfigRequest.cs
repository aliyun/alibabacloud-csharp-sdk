// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class TestEventSourceConfigRequest : TeaModel {
        [NameInMap("SourceMySQLParameters")]
        [Validation(Required=false)]
        public TestEventSourceConfigRequestSourceMySQLParameters SourceMySQLParameters { get; set; }
        public class TestEventSourceConfigRequestSourceMySQLParameters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>database1</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rm-bp1vxxx.mysql.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PrivateNetwork</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234xxx</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sg-xxx</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>database1.table1</para>
            /// </summary>
            [NameInMap("TableNames")]
            [Validation(Required=false)]
            public string TableNames { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user***</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-bp1gb7xxx</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public string VSwitchIds { get; set; }

            /// <summary>
            /// <para>VPC ID。</para>
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
