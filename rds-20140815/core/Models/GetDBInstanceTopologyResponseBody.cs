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
        /// <para>The topology details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDBInstanceTopologyResponseBodyData Data { get; set; }
        public class GetDBInstanceTopologyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The network connectivity information of the instance.</para>
            /// </summary>
            [NameInMap("Connections")]
            [Validation(Required=false)]
            public List<GetDBInstanceTopologyResponseBodyDataConnections> Connections { get; set; }
            public class GetDBInstanceTopologyResponseBodyDataConnections : TeaModel {
                /// <summary>
                /// <para>The database endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-m5ezban****mysql.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-m5ezban****</para>
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

                /// <summary>
                /// <para>The network endpoint type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>vpc</b>: internal endpoint.</description></item>
                /// <item><description><b>public</b>: public endpoint.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
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
            /// <para>rm-m5ezban****</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The node list.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetDBInstanceTopologyResponseBodyDataNodes> Nodes { get; set; }
            public class GetDBInstanceTopologyResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-m5ezban****</para>
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

                /// <summary>
                /// <para>The dedicated cluster ID.</para>
                /// <remarks>
                /// <para>This parameter is empty for non-dedicated cluster instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>dhg-4n****</para>
                /// </summary>
                [NameInMap("DedicatedHostGroupId")]
                [Validation(Required=false)]
                public string DedicatedHostGroupId { get; set; }

                /// <summary>
                /// <para>The host ID in the dedicated cluster.</para>
                /// <remarks>
                /// <para>This parameter is empty for non-dedicated cluster instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp****</para>
                /// </summary>
                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }

                /// <summary>
                /// <para>The unique identifier of the instance.</para>
                /// <remarks>
                /// <para>This parameter returns <b>-1</b> for non-dedicated cluster instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>349054</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Master</b>: primary node.</description></item>
                /// <item><description><b>Slave</b>: secondary node.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>master</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7430AB1A-6D49-5B6D-B9E5-920250076074</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
