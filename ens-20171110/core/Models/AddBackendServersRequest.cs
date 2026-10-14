// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AddBackendServersRequest : TeaModel {
        /// <summary>
        /// <para>The list of backend servers to add. You can add up to 20 backend servers per invoke.</para>
        /// <remarks>
        /// <para>Backend servers (ENS instances) must be in the Running state before they can be added to a load balancing instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public List<AddBackendServersRequestBackendServers> BackendServers { get; set; }
        public class AddBackendServersRequestBackendServers : TeaModel {
            /// <summary>
            /// <para>The IP address of the backend server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XXX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The backend port used by the load balancing instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3309</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The ENS instance ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-5uf6dwyzch3wly790****</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <para>The backend server type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ens</b>: ENS instance.</description></item>
            /// <item><description><b>eni</b>: network interface controller (NIC) instance.</description></item>
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
            /// <para>A value of 0 indicates that no requests are forwarded to the backend server.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The frontend port used by the load balancing instance. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5qzdmxefgrpxd7oz2mefonvtx</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

    }

}
