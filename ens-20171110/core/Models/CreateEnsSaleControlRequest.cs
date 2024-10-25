// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEnsSaleControlRequest : TeaModel {
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
        public List<CreateEnsSaleControlRequestSaleControls> SaleControls { get; set; }
        public class CreateEnsSaleControlRequestSaleControls : TeaModel {
            [NameInMap("ConditionControls")]
            [Validation(Required=false)]
            public List<CreateEnsSaleControlRequestSaleControlsConditionControls> ConditionControls { get; set; }
            public class CreateEnsSaleControlRequestSaleControlsConditionControls : TeaModel {
                [NameInMap("ConditionControlModuleCode")]
                [Validation(Required=false)]
                public string ConditionControlModuleCode { get; set; }

                [NameInMap("ConditionControlModuleValue")]
                [Validation(Required=false)]
                public string ConditionControlModuleValue { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ModuleValue")]
            [Validation(Required=false)]
            public CreateEnsSaleControlRequestSaleControlsModuleValue ModuleValue { get; set; }
            public class CreateEnsSaleControlRequestSaleControlsModuleValue : TeaModel {
                [NameInMap("ModuleMaxValue")]
                [Validation(Required=false)]
                public string ModuleMaxValue { get; set; }

                [NameInMap("ModuleMinValue")]
                [Validation(Required=false)]
                public string ModuleMinValue { get; set; }

                [NameInMap("ModuleValue")]
                [Validation(Required=false)]
                public List<string> ModuleValue { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

        }

    }

}
