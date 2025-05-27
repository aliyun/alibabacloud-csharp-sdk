// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class DiscoverEventSourceRequest : TeaModel {
        [NameInMap("SourceMySQLParameters")]
        [Validation(Required=false)]
        public DiscoverEventSourceRequestSourceMySQLParameters SourceMySQLParameters { get; set; }
        public class DiscoverEventSourceRequestSourceMySQLParameters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>database1</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rm-xxx.mysql.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Limit")]
            [Validation(Required=false)]
            public string Limit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PrivateNetwork</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Offset")]
            [Validation(Required=false)]
            public string Offset { get; set; }

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
            /// <para>sg-bp1ic0vsbwyv176e9inx</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>database1.table1</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-gw824tpaptxtlo256lqub</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public string VSwitchIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-uf6hwiei8u5uil3bfahc1</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
