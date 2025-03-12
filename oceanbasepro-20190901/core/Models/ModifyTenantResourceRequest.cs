// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantResourceRequest : TeaModel {
        /// <summary>
        /// <para>The information about the CPU resources of the tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The ID of the OceanBase cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The size of the log disk allocated to the tenant, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("LogDisk")]
        [Validation(Required=false)]
        public long? LogDisk { get; set; }

        /// <summary>
        /// <para>The memory size of the tenant, in GB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies to create a read-only zone. Separate the names of multiple zones with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-g-ro,cn-shanghai-h-ro</para>
        /// </summary>
        [NameInMap("ReadOnlyZoneList")]
        [Validation(Required=false)]
        [Obsolete]
        public string ReadOnlyZoneList { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob2mr3oae0****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
