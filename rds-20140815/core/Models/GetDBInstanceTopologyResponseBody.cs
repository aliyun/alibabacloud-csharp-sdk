// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class GetDBInstanceTopologyResponseBody : TeaModel {
        /// <summary>
        /// <para>An internal parameter. You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details about the topology.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDBInstanceTopologyResponseBodyData Data { get; set; }
        public class GetDBInstanceTopologyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The network connection information of the instance.</para>
            /// </summary>
            [NameInMap("Connections")]
            [Validation(Required=false)]
            public List<GetDBInstanceTopologyResponseBodyDataConnections> Connections { get; set; }
            public class GetDBInstanceTopologyResponseBodyDataConnections : TeaModel {
                /// <summary>
                /// <para>The endpoint that is used to connect to the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-m5ezban**********.mysql.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-m5ezban**********</para>
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

                /// <summary>
                /// <para>The network type of the endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>vpc</b></description></item>
                /// <item><description><b>public</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The zone ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao-c</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-m5ezban**********</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The queried nodes.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetDBInstanceTopologyResponseBodyDataNodes> Nodes { get; set; }
            public class GetDBInstanceTopologyResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-m5ezban**********</para>
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

                /// <summary>
                /// <para>The ID of the dedicated cluster.</para>
                /// <remarks>
                /// <para>: If the instance does not reside in the specified dedicated cluster, no value is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>dhg-4n*****</para>
                /// </summary>
                [NameInMap("DedicatedHostGroupId")]
                [Validation(Required=false)]
                public string DedicatedHostGroupId { get; set; }

                /// <summary>
                /// <para>The host ID of the instance in the dedicated cluster.</para>
                /// <remarks>
                /// <para>: If the instance does not reside in the specified dedicated cluster, no value is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>i-bpxxxxxxx</para>
                /// </summary>
                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// <remarks>
                /// <para>: The value \<em>\</em>-1\<em>\</em> is returned for an instance that does not reside in a dedicated cluster.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>349054</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The type of the node. The following result is returned:</para>
                /// <list type="bullet">
                /// <item><description><b>Master</b>: a primary node</description></item>
                /// <item><description><b>Slave</b>: a secondary node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>master</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The zone ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao-c</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>An internal parameter. You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7430AB1A-6D49-5B6D-B9E5-920250076074</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
