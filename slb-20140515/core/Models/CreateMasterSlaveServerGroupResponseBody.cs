// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateMasterSlaveServerGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend servers in the primary/secondary server group.</para>
        /// </summary>
        [NameInMap("MasterSlaveBackendServers")]
        [Validation(Required=false)]
        public CreateMasterSlaveServerGroupResponseBodyMasterSlaveBackendServers MasterSlaveBackendServers { get; set; }
        public class CreateMasterSlaveServerGroupResponseBodyMasterSlaveBackendServers : TeaModel {
            [NameInMap("MasterSlaveBackendServer")]
            [Validation(Required=false)]
            public List<CreateMasterSlaveServerGroupResponseBodyMasterSlaveBackendServersMasterSlaveBackendServer> MasterSlaveBackendServer { get; set; }
            public class CreateMasterSlaveServerGroupResponseBodyMasterSlaveBackendServersMasterSlaveBackendServer : TeaModel {
                /// <summary>
                /// <para>The description of the primary/secondary server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-112</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The port that is used by the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>82</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The ID of the backend server that you want to add.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1fq61enf4loa5i****</para>
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

                /// <summary>
                /// <para>The type of backend server.</para>
                /// <para>Valid values: <b>Master</b> and <b>Slave</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Master</para>
                /// </summary>
                [NameInMap("ServerType")]
                [Validation(Required=false)]
                public string ServerType { get; set; }

                /// <summary>
                /// <para>The type of backend server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ecs</b>: ECS instance</description></item>
                /// <item><description><b>eni</b>: ENI</description></item>
                /// <item><description><b>eci</b>: elastic container instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The weight of the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the active/standby server group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-bp19au4******</para>
        /// </summary>
        [NameInMap("MasterSlaveServerGroupId")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7CA4DB76-4D32-523B-822E-5C9494613D46</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
