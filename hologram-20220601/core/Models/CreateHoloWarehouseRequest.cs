// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class CreateHoloWarehouseRequest : TeaModel {
        /// <summary>
        /// <para>The specifications of the virtual warehouse. The number of vCPUs must be an integer multiple of 16 CPUs. Minimum value: 16.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public string Cpu { get; set; }

        /// <summary>
        /// <para>The name of the virtual warehouse.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_warehouse</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
