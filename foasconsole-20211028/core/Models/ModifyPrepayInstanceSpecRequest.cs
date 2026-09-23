// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class ModifyPrepayInstanceSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable zone-disaster recovery resources for the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Ha")]
        [Validation(Required=false)]
        public bool? Ha { get; set; }

        /// <summary>
        /// <para>The resource specifications for zone-disaster recovery.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("HaResourceSpec")]
        [Validation(Required=false)]
        public ModifyPrepayInstanceSpecRequestHaResourceSpec HaResourceSpec { get; set; }
        public class ModifyPrepayInstanceSpecRequestHaResourceSpec : TeaModel {
            /// <summary>
            /// <para>The number of CPUs for zone-disaster recovery resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The memory size of zone-disaster recovery resources, in GB. The value must be 4 times the number of CPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("MemoryGB")]
            [Validation(Required=false)]
            public int? MemoryGB { get; set; }

        }

        /// <summary>
        /// <para>The list of vSwitch IDs in the secondary zone for zone-disaster recovery.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("HaVSwitchIds")]
        [Validation(Required=false)]
        public List<string> HaVSwitchIds { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone for zone-disaster recovery.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("HaZoneId")]
        [Validation(Required=false)]
        public string HaZoneId { get; set; }

        /// <summary>
        /// <para>The order instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f-cn-wwo36qj4g06</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The resource specification information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceSpec")]
        [Validation(Required=false)]
        public ModifyPrepayInstanceSpecRequestResourceSpec ResourceSpec { get; set; }
        public class ModifyPrepayInstanceSpecRequestResourceSpec : TeaModel {
            /// <summary>
            /// <para>The number of CPUs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The memory size.</para>
            /// <remarks>
            /// <para>The memory size must be 4 times the number of CPUs.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("MemoryGB")]
            [Validation(Required=false)]
            public int? MemoryGB { get; set; }

        }

    }

}
