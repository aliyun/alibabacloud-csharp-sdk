// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class AddBackendServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of backend servers.</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public AddBackendServersResponseBodyBackendServers BackendServers { get; set; }
        public class AddBackendServersResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<AddBackendServersResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class AddBackendServersResponseBodyBackendServersBackendServer : TeaModel {
                /// <summary>
                /// <para>The description of the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>backend server</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the ECS instance, ENI, or elastic container instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2zej4lxhjoq1icu*****</para>
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

                /// <summary>
                /// <para>The type of the backend server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ecs</b> (default): an ECS instance</description></item>
                /// <item><description><b>eni</b>: an ENI</description></item>
                /// <item><description><b>eci</b>: an elastic container instance</description></item>
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
                /// <para>Valid values: <b>0 to 100</b>. Default value: <b>100</b>.</para>
                /// <para>If the value is set to <b>0</b>, no requests are forwarded to the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public string Weight { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-2ze7o5h52g02kkzz****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34B82C81-F13B-4EEB-99F6-A048C67CC830</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
