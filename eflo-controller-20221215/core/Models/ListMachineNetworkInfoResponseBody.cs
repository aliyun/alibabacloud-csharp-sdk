// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListMachineNetworkInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>machine network infomation</para>
        /// </summary>
        [NameInMap("MachineNetworkInfo")]
        [Validation(Required=false)]
        public List<ListMachineNetworkInfoResponseBodyMachineNetworkInfo> MachineNetworkInfo { get; set; }
        public class ListMachineNetworkInfoResponseBodyMachineNetworkInfo : TeaModel {
            /// <summary>
            /// <para>Network of cluster</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc/acl</para>
            /// </summary>
            [NameInMap("ClusterNet")]
            [Validation(Required=false)]
            public string ClusterNet { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the Jumbo Frames feature for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The Jumbo Frame feature is enabled for the instance.</description></item>
            /// <item><description>false: The Jumbo Frame feature is disabled for the instance.</description></item>
            /// </list>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The instance must be in the Running (<c>Running</c>) or Stopped (<c>Stopped</c>) state.</description></item>
            /// <item><description>The instance must reside in a VPC.</description></item>
            /// <item><description>After the Jumbo Frames feature is enabled, the MTU value of the instance is set to 8500. After the Jumbo Frames feature is disabled, the MTU value of the instance is set to 1500. You can enable the Jumbo Frames feature only for specific instance types. For more information, see <a href="https://help.aliyun.com/document_detail/200512.html">Jumbo Frames</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableJumboFrame")]
            [Validation(Required=false)]
            public bool? EnableJumboFrame { get; set; }

            /// <summary>
            /// <para>HPN zone</para>
            /// 
            /// <b>Example:</b>
            /// <para>B1</para>
            /// </summary>
            [NameInMap("HpnZone")]
            [Validation(Required=false)]
            public string HpnZone { get; set; }

            /// <summary>
            /// <para>Specifies whether dpu machine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDpuMode")]
            [Validation(Required=false)]
            public bool? IsDpuMode { get; set; }

            /// <summary>
            /// <para>The type of machine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>efg1.nvga8n</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <para>Network architecture</para>
            /// 
            /// <b>Example:</b>
            /// <para>XX-7.0</para>
            /// </summary>
            [NameInMap("NetArch")]
            [Validation(Required=false)]
            public string NetArch { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the application is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
