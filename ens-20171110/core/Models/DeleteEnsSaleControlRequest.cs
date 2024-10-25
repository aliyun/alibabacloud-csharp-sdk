// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteEnsSaleControlRequest : TeaModel {
        [NameInMap("AliUidAccount")]
        [Validation(Required=false)]
        public string AliUidAccount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("CustomAccount")]
        [Validation(Required=false)]
        public string CustomAccount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SaleControls")]
        [Validation(Required=false)]
        public List<DeleteEnsSaleControlRequestSaleControls> SaleControls { get; set; }
        public class DeleteEnsSaleControlRequestSaleControls : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

        }

    }

}
