// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CheckResourceStockResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>805D8FB6-512A-531C-9E4D-2A807D3C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceStockModels")]
        [Validation(Required=false)]
        public List<CheckResourceStockResponseBodyResourceStockModels> ResourceStockModels { get; set; }
        public class CheckResourceStockResponseBodyResourceStockModels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("StockStatus")]
            [Validation(Required=false)]
            public string StockStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
