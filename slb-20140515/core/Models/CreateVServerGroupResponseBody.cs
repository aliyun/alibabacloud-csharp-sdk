// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateVServerGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of backend servers.</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public CreateVServerGroupResponseBodyBackendServers BackendServers { get; set; }
        public class CreateVServerGroupResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<CreateVServerGroupResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class CreateVServerGroupResponseBodyBackendServersBackendServer : TeaModel {
                /// <summary>
                /// <para>The description of the vServer group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>backend server</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The port that is used by the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The ID of the ECS instance or ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-hhshhs****</para>
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

                /// <summary>
                /// <para>The type of backend server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ecs</b> (default): ECS instance</description></item>
                /// <item><description><b>eni</b>: elastic network interface (ENI)</description></item>
                /// <item><description><b>eci</b>: elastic container instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>eni</para>
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
        /// <para>The ID of the request.</para>
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
        /// <para>rsp-cige6******</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
