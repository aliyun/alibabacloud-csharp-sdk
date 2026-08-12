// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class ModifyNamespaceSpecV2Request : TeaModel {
        /// <summary>
        /// <para>The upper limit of pay-as-you-go resources allocated to the project namespace.</para>
        /// </summary>
        [NameInMap("ElasticResourceSpec")]
        [Validation(Required=false)]
        public ModifyNamespaceSpecV2RequestElasticResourceSpec ElasticResourceSpec { get; set; }
        public class ModifyNamespaceSpecV2RequestElasticResourceSpec : TeaModel {
            /// <summary>
            /// <para>The number of CPUs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: GB.</para>
            /// <remarks>
            /// <para>The memory size must be 4 times the number of CPUs.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>52</para>
            /// </summary>
            [NameInMap("MemoryGB")]
            [Validation(Required=false)]
            public int? MemoryGB { get; set; }

        }

        /// <summary>
        /// <para>The size of subscription resources allocated to the project namespace.</para>
        /// </summary>
        [NameInMap("GuaranteedResourceSpec")]
        [Validation(Required=false)]
        public ModifyNamespaceSpecV2RequestGuaranteedResourceSpec GuaranteedResourceSpec { get; set; }
        public class ModifyNamespaceSpecV2RequestGuaranteedResourceSpec : TeaModel {
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
            /// <para>The memory size. Unit: GB.</para>
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

        /// <summary>
        /// <para>Specifies whether the project namespace uses zone-disaster recovery.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Ha")]
        [Validation(Required=false)]
        public bool? Ha { get; set; }

        /// <summary>
        /// <para>The order instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f-cn-wwo36qj****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The project namespace name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>di-5934394438****</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

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

    }

}
