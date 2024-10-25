// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteEnsSaleConditionControlRequest : TeaModel {
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
        public List<DeleteEnsSaleConditionControlRequestSaleControls> SaleControls { get; set; }
        public class DeleteEnsSaleConditionControlRequestSaleControls : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ConditionControls")]
            [Validation(Required=false)]
            public List<DeleteEnsSaleConditionControlRequestSaleControlsConditionControls> ConditionControls { get; set; }
            public class DeleteEnsSaleConditionControlRequestSaleControlsConditionControls : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ConditionControlModuleCode")]
                [Validation(Required=false)]
                public string ConditionControlModuleCode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ConditionControlModuleValue")]
                [Validation(Required=false)]
                public string ConditionControlModuleValue { get; set; }

            }

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
