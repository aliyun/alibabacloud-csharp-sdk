// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListMachineNetworkInfoResponseBody : TeaModel {
        [NameInMap("MachineNetworkInfo")]
        [Validation(Required=false)]
        public List<ListMachineNetworkInfoResponseBodyMachineNetworkInfo> MachineNetworkInfo { get; set; }
        public class ListMachineNetworkInfoResponseBodyMachineNetworkInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc/acl</para>
            /// </summary>
            [NameInMap("ClusterNet")]
            [Validation(Required=false)]
            public string ClusterNet { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableJumboFrame")]
            [Validation(Required=false)]
            public bool? EnableJumboFrame { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>B1</para>
            /// </summary>
            [NameInMap("HpnZone")]
            [Validation(Required=false)]
            public string HpnZone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDpuMode")]
            [Validation(Required=false)]
            public bool? IsDpuMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>efg1.nvga8n</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>XX-7.0</para>
            /// </summary>
            [NameInMap("NetArch")]
            [Validation(Required=false)]
            public string NetArch { get; set; }

            /// <summary>
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
