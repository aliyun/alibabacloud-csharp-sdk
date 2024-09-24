// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterCnnfStatusDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the protection status of the container firewall.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListClusterCnnfStatusDetailResponseBodyData> Data { get; set; }
        public class ListClusterCnnfStatusDetailResponseBodyData : TeaModel {
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
            /// <para>Indicates whether the container firewall plug-in is installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Installed")]
            [Validation(Required=false)]
            public bool? Installed { get; set; }

            /// <summary>
            /// <para>The ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp180bogui4fc0z4****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The public IP address of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.42.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The cause why the plug-in is invalid. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PLUGIN_OFFLINE</b>: The plug-in is offline.</description></item>
            /// <item><description><b>PLUGIN_NOT_INSTALLED</b>: The plug-in is not installed.</description></item>
            /// <item><description><b>PLUGIN_INVALID_VERSION</b>: The version of the plug-in is invalid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PLUGIN_OFFLINE</para>
            /// </summary>
            [NameInMap("InvalidType")]
            [Validation(Required=false)]
            public string InvalidType { get; set; }

            /// <summary>
            /// <para>The name of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>security</para>
            /// </summary>
            [NameInMap("MachineName")]
            [Validation(Required=false)]
            public string MachineName { get; set; }

            /// <summary>
            /// <para>The machine type of the instance. The value is fixed as <b>ecs</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public int? MachineType { get; set; }

            /// <summary>
            /// <para>The name of the plug-in. The value is fixed as <b>alinet</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alinet</para>
            /// </summary>
            [NameInMap("PluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            /// <summary>
            /// <para>The version of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.3</para>
            /// </summary>
            [NameInMap("PluginVersion")]
            [Validation(Required=false)]
            public string PluginVersion { get; set; }

            /// <summary>
            /// <para>The online status of the plug-in. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: The plug-in is offline.</description></item>
            /// <item><description><b>true</b>: The plug-in is online.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The UUID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6690a46c-0edb-4663-a641-3629d1a9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64329F40-5C94-51D3-A400-37AA7BAC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
