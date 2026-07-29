// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class EnableWarehouseAutoScaleRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of clusters. The value must be greater than the number of reserved clusters and less than or equal to 4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("maxClusterCount")]
        [Validation(Required=false)]
        public string MaxClusterCount { get; set; }

        /// <summary>
        /// <para>The name of the warehouse.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_warehouse</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
