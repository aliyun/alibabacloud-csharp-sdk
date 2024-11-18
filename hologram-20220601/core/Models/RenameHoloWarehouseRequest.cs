// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class RenameHoloWarehouseRequest : TeaModel {
        /// <summary>
        /// <para>The original name of the virtual warehouse.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_warehouse</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The new name of the virtual warehouse.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new_name</para>
        /// </summary>
        [NameInMap("newWarehouseName")]
        [Validation(Required=false)]
        public string NewWarehouseName { get; set; }

    }

}
