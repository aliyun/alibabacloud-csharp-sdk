// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RemoveBackendServersRequest : TeaModel {
        /// <summary>
        /// <para>The list of backend servers that you want to remove. You can remove up to 20 backend servers at a time.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public List<RemoveBackendServersRequestBackendServers> BackendServers { get; set; }
        public class RemoveBackendServersRequestBackendServers : TeaModel {
            /// <summary>
            /// <para>The IP address of the backend server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XXX.X.X</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The backend port that is used by the Edge Load Balancer (ELB) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The instance ID of the backend server.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-5uf68ts0fqexe1a4n****</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <para>The type of backend server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ens</b>: an Edge Node Service (ENS) instance.</description></item>
            /// <item><description><b>eni</b>: an Elastic Network Interface (ENI).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ens</para>
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

        /// <summary>
        /// <para>The ID of the Edge Load Balancer (ELB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5ovkn1piwqmoqrfjdyhq4****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

    }

}
