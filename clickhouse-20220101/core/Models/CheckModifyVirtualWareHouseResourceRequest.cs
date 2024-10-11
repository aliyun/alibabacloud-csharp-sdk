// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class CheckModifyVirtualWareHouseResourceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cc-bp108z124a8o7****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("VirtualWareHouseCacheStorage")]
        [Validation(Required=false)]
        public int? VirtualWareHouseCacheStorage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n1.xlarge</para>
        /// </summary>
        [NameInMap("VirtualWareHouseClass")]
        [Validation(Required=false)]
        public string VirtualWareHouseClass { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vw-uf6a499c0m3w5****</para>
        /// </summary>
        [NameInMap("VirtualWareHouseId")]
        [Validation(Required=false)]
        public string VirtualWareHouseId { get; set; }

    }

}
