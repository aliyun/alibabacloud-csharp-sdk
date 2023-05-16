// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsSaleControlStockResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SaleControl")]
        [Validation(Required=false)]
        public List<DescribeEnsSaleControlStockResponseBodySaleControl> SaleControl { get; set; }
        public class DescribeEnsSaleControlStockResponseBodySaleControl : TeaModel {
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            [NameInMap("SaleControlItems")]
            [Validation(Required=false)]
            public List<DescribeEnsSaleControlStockResponseBodySaleControlSaleControlItems> SaleControlItems { get; set; }
            public class DescribeEnsSaleControlStockResponseBodySaleControlSaleControlItems : TeaModel {
                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                [NameInMap("SaleControlItem")]
                [Validation(Required=false)]
                public DescribeEnsSaleControlStockResponseBodySaleControlSaleControlItemsSaleControlItem SaleControlItem { get; set; }
                public class DescribeEnsSaleControlStockResponseBodySaleControlSaleControlItemsSaleControlItem : TeaModel {
                    [NameInMap("BasicSaleControl")]
                    [Validation(Required=false)]
                    public DescribeEnsSaleControlStockResponseBodySaleControlSaleControlItemsSaleControlItemBasicSaleControl BasicSaleControl { get; set; }
                    public class DescribeEnsSaleControlStockResponseBodySaleControlSaleControlItemsSaleControlItemBasicSaleControl : TeaModel {
                        [NameInMap("ModuleValue")]
                        [Validation(Required=false)]
                        public DescribeEnsSaleControlStockResponseBodySaleControlSaleControlItemsSaleControlItemBasicSaleControlModuleValue ModuleValue { get; set; }
                        public class DescribeEnsSaleControlStockResponseBodySaleControlSaleControlItemsSaleControlItemBasicSaleControlModuleValue : TeaModel {
                            [NameInMap("ModuleMaxValue")]
                            [Validation(Required=false)]
                            public string ModuleMaxValue { get; set; }

                            [NameInMap("ModuleMinValue")]
                            [Validation(Required=false)]
                            public string ModuleMinValue { get; set; }

                        }

                        [NameInMap("StockValue")]
                        [Validation(Required=false)]
                        public string StockValue { get; set; }

                    }

                    [NameInMap("ConditionSaleControl")]
                    [Validation(Required=false)]
                    public List<DescribeEnsSaleControlStockResponseBodySaleControlSaleControlItemsSaleControlItemConditionSaleControl> ConditionSaleControl { get; set; }
                    public class DescribeEnsSaleControlStockResponseBodySaleControlSaleControlItemsSaleControlItemConditionSaleControl : TeaModel {
                        [NameInMap("ConditionControl")]
                        [Validation(Required=false)]
                        public DescribeEnsSaleControlStockResponseBodySaleControlSaleControlItemsSaleControlItemConditionSaleControlConditionControl ConditionControl { get; set; }
                        public class DescribeEnsSaleControlStockResponseBodySaleControlSaleControlItemsSaleControlItemConditionSaleControlConditionControl : TeaModel {
                            [NameInMap("ConditionControlModuleCode")]
                            [Validation(Required=false)]
                            public string ConditionControlModuleCode { get; set; }

                            [NameInMap("ConditionControlModuleValue")]
                            [Validation(Required=false)]
                            public string ConditionControlModuleValue { get; set; }

                        }

                        [NameInMap("ModuleValue")]
                        [Validation(Required=false)]
                        public DescribeEnsSaleControlStockResponseBodySaleControlSaleControlItemsSaleControlItemConditionSaleControlModuleValue ModuleValue { get; set; }
                        public class DescribeEnsSaleControlStockResponseBodySaleControlSaleControlItemsSaleControlItemConditionSaleControlModuleValue : TeaModel {
                            [NameInMap("ModuleMaxValue")]
                            [Validation(Required=false)]
                            public string ModuleMaxValue { get; set; }

                            [NameInMap("ModuleMinValue")]
                            [Validation(Required=false)]
                            public string ModuleMinValue { get; set; }

                        }

                        [NameInMap("StockValue")]
                        [Validation(Required=false)]
                        public string StockValue { get; set; }

                    }

                }

            }

        }

    }

}
