// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeReplicaSetRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bpxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The details of the roles of the replica set instance.</para>
        /// </summary>
        [NameInMap("ReplicaSets")]
        [Validation(Required=false)]
        public DescribeReplicaSetRoleResponseBodyReplicaSets ReplicaSets { get; set; }
        public class DescribeReplicaSetRoleResponseBodyReplicaSets : TeaModel {
            [NameInMap("ReplicaSet")]
            [Validation(Required=false)]
            public List<DescribeReplicaSetRoleResponseBodyReplicaSetsReplicaSet> ReplicaSet { get; set; }
            public class DescribeReplicaSetRoleResponseBodyReplicaSetsReplicaSet : TeaModel {
                /// <summary>
                /// <para>The endpoint of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dds-bpxxxxxxxx.mongodb.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionDomain")]
                [Validation(Required=false)]
                public string ConnectionDomain { get; set; }

                /// <summary>
                /// <para>The port number that is used to connect to the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3717</para>
                /// </summary>
                [NameInMap("ConnectionPort")]
                [Validation(Required=false)]
                public string ConnectionPort { get; set; }

                /// <summary>
                /// <para>The connection type of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SRV</para>
                /// </summary>
                [NameInMap("ConnectionType")]
                [Validation(Required=false)]
                public string ConnectionType { get; set; }

                /// <summary>
                /// <para>The remaining duration of the classic network endpoint. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1209582</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The network type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>VPC</b>: the virtual private cloud (VPC)</description></item>
                /// <item><description><b>Classic</b>: the classic network</description></item>
                /// <item><description><b>Public</b>: the Internet</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The role of the node in the replica set instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Primary</b></description></item>
                /// <item><description><b>Secondary</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Primary</para>
                /// </summary>
                [NameInMap("ReplicaSetRole")]
                [Validation(Required=false)]
                public string ReplicaSetRole { get; set; }

                /// <summary>
                /// <para>The role ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>651xxxxx</para>
                /// </summary>
                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DB4A0595-FCA9-437F-B2BB-25DBFC009D3E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
