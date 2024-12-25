// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class RemoveVServerGroupBackendServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend servers.</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public RemoveVServerGroupBackendServersResponseBodyBackendServers BackendServers { get; set; }
        public class RemoveVServerGroupBackendServersResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<RemoveVServerGroupBackendServersResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class RemoveVServerGroupBackendServersResponseBodyBackendServersBackendServer : TeaModel {
                /// <summary>
                /// <para>The port that is used by the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The ID of the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vm-230</para>
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

                /// <summary>
                /// <para>The type of the backend server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ecs</b> (default): ECS instance</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DEC9C28-AB05-4DDF-9A78-6B08EC9CE18C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the vServer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-cige6j****</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
