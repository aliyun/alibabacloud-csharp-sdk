// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetBackendServersRequest : TeaModel {
        /// <summary>
        /// <para>The list of backend servers that you added. You can modify the weights of up to 20 backend servers in each request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public List<SetBackendServersRequestBackendServers> BackendServers { get; set; }
        public class SetBackendServersRequestBackendServers : TeaModel {
            /// <summary>
            /// <para>The ID of the instance that you use as the backend server.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-5ze0o05xccvbljtn****</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <para>The type of the backend server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ens</b>: ENS instance</description></item>
            /// <item><description><b>eni</b>: elastic network interface (ENI)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ens</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The weight of the backend server. Default value: 100. Valid values: <b>0</b> to <b>100</b>.</para>
            /// <remarks>
            /// <para> The value 0 indicates that requests are not forwarded to the backend server.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Edge Load Balancer (ELB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5s7crik3yo3bp03gqrbp5****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

    }

}
