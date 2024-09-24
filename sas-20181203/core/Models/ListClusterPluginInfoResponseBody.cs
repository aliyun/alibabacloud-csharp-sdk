// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterPluginInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the plug-in.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListClusterPluginInfoResponseBodyData> Data { get; set; }
        public class ListClusterPluginInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c8ca91e0907d94efaba7fb0827eb9****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lmftest</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The status of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: normal</description></item>
            /// <item><description>2: abnormal</description></item>
            /// <item><description>3: offline</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ABNORMAL</para>
            /// </summary>
            [NameInMap("ClusterStatus")]
            [Validation(Required=false)]
            public string ClusterStatus { get; set; }

            /// <summary>
            /// <para>The plug-ins.</para>
            /// </summary>
            [NameInMap("NodePluginInfoList")]
            [Validation(Required=false)]
            public List<ListClusterPluginInfoResponseBodyDataNodePluginInfoList> NodePluginInfoList { get; set; }
            public class ListClusterPluginInfoResponseBodyDataNodePluginInfoList : TeaModel {
                /// <summary>
                /// <para>The error code returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kenerl not support</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kenerl not support</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>Indicates whether the plug-in is installed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Installed")]
                [Validation(Required=false)]
                public bool? Installed { get; set; }

                /// <summary>
                /// <para>The public IP address of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.100.XXX.XX</para>
                /// </summary>
                [NameInMap("MachineInternetIp")]
                [Validation(Required=false)]
                public string MachineInternetIp { get; set; }

                /// <summary>
                /// <para>The private IP address of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.XXX.XXX.XX</para>
                /// </summary>
                [NameInMap("MachineIntranetIp")]
                [Validation(Required=false)]
                public string MachineIntranetIp { get; set; }

                /// <summary>
                /// <para>The name of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>npznas05</para>
                /// </summary>
                [NameInMap("MachineName")]
                [Validation(Required=false)]
                public string MachineName { get; set; }

                /// <summary>
                /// <para>The type of the instance. Valid values include:</para>
                /// <list type="bullet">
                /// <item><description><b>ecs</b>: Elastic Compute Service (ECS) instance</description></item>
                /// <item><description><b>slb</b>: Server Load Balancer (SLB) instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("MachineType")]
                [Validation(Required=false)]
                public long? MachineType { get; set; }

                /// <summary>
                /// <para>Indicates whether the Security Center agent is online. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> If the Security Center agent of the server is offline, Security Center does not protect the server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Online")]
                [Validation(Required=false)]
                public bool? Online { get; set; }

                /// <summary>
                /// <para>The name of the plug-in.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alihips</para>
                /// </summary>
                [NameInMap("PluginName")]
                [Validation(Required=false)]
                public string PluginName { get; set; }

                /// <summary>
                /// <para>The version of the plug-in.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.3.1</para>
                /// </summary>
                [NameInMap("PluginVersion")]
                [Validation(Required=false)]
                public string PluginVersion { get; set; }

                /// <summary>
                /// <para>The UUID of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bc563d2b-2a3d-411b-8bbe-d75b8d3c****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

                /// <summary>
                /// <para>The instance ID of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tpp-cn-2r42njq4y001</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF46038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
