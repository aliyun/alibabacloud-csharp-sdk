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

        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("SaleControls")]
        [Validation(Required=false)]
        public List<DeleteEnsSaleConditionControlRequestSaleControls> SaleControls { get; set; }
        public class DeleteEnsSaleConditionControlRequestSaleControls : TeaModel {
            [NameInMap("ConditionControls")]
            [Validation(Required=false)]
            public List<DeleteEnsSaleConditionControlRequestSaleControlsConditionControls> ConditionControls { get; set; }
            public class DeleteEnsSaleConditionControlRequestSaleControlsConditionControls : TeaModel {
                [NameInMap("ConditionControlModuleCode")]
                [Validation(Required=false)]
                public string ConditionControlModuleCode { get; set; }

                [NameInMap("ConditionControlModuleValue")]
                [Validation(Required=false)]
                public string ConditionControlModuleValue { get; set; }

            }

            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

        }

    }

}
