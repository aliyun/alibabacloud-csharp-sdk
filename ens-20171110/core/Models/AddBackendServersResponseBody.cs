// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AddBackendServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of backend servers that you want to add. You can add at most 20 backend servers.</para>
        /// <remarks>
        /// <para> Only ENS instances that are in the running state can be attached to the ELB instance as backend servers.</para>
        /// </remarks>
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
                /// <para>The IP address of the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.1</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The backend port that is used by the ELB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The ID of the instance that is used as the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-5uf6hj58zvml4ali8****</para>
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

                /// <summary>
                /// <para>The type of the backend server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ens</b>: ENS instance.</description></item>
                /// <item><description><b>eni</b>: ENI.</description></item>
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
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
