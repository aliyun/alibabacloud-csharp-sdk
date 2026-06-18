// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListMachineNetworkInfoRequest : TeaModel {
        /// <summary>
        /// <para>The information about the machine types.</para>
        /// </summary>
        [NameInMap("MachineHpnInfo")]
        [Validation(Required=false)]
        public List<ListMachineNetworkInfoRequestMachineHpnInfo> MachineHpnInfo { get; set; }
        public class ListMachineNetworkInfoRequestMachineHpnInfo : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C1</para>
            /// </summary>
            [NameInMap("HpnZone")]
            [Validation(Required=false)]
            public string HpnZone { get; set; }

            /// <summary>
            /// <para>The machine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>efg2.C48cNHmcn</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}
