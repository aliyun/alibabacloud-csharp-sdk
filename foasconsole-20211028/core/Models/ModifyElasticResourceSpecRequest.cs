// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class ModifyElasticResourceSpecRequest : TeaModel {
        /// <summary>
        /// <para>The order instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sc_flinkserverless_public_cn-7e22ae****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The maximum pay-as-you-go resource specifications.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceSpec")]
        [Validation(Required=false)]
        public ModifyElasticResourceSpecRequestResourceSpec ResourceSpec { get; set; }
        public class ModifyElasticResourceSpecRequestResourceSpec : TeaModel {
            /// <summary>
            /// <para>The number of CPUs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
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
            /// <para>40</para>
            /// </summary>
            [NameInMap("MemoryGB")]
            [Validation(Required=false)]
            public int? MemoryGB { get; set; }

        }

    }

}
