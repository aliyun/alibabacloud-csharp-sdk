// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsSaleControlResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SaleControl")]
        [Validation(Required=false)]
        public List<DescribeEnsSaleControlResponseBodySaleControl> SaleControl { get; set; }
        public class DescribeEnsSaleControlResponseBodySaleControl : TeaModel {
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            [NameInMap("SaleControlItems")]
            [Validation(Required=false)]
            public List<DescribeEnsSaleControlResponseBodySaleControlSaleControlItems> SaleControlItems { get; set; }
            public class DescribeEnsSaleControlResponseBodySaleControlSaleControlItems : TeaModel {
                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                [NameInMap("SaleControlItem")]
                [Validation(Required=false)]
                public DescribeEnsSaleControlResponseBodySaleControlSaleControlItemsSaleControlItem SaleControlItem { get; set; }
                public class DescribeEnsSaleControlResponseBodySaleControlSaleControlItemsSaleControlItem : TeaModel {
                    [NameInMap("BasicSaleControl")]
                    [Validation(Required=false)]
                    public DescribeEnsSaleControlResponseBodySaleControlSaleControlItemsSaleControlItemBasicSaleControl BasicSaleControl { get; set; }
                    public class DescribeEnsSaleControlResponseBodySaleControlSaleControlItemsSaleControlItemBasicSaleControl : TeaModel {
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("ModuleValue")]
                        [Validation(Required=false)]
                        public DescribeEnsSaleControlResponseBodySaleControlSaleControlItemsSaleControlItemBasicSaleControlModuleValue ModuleValue { get; set; }
                        public class DescribeEnsSaleControlResponseBodySaleControlSaleControlItemsSaleControlItemBasicSaleControlModuleValue : TeaModel {
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

                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                    }

                    [NameInMap("ConditionSaleControl")]
                    [Validation(Required=false)]
                    public List<DescribeEnsSaleControlResponseBodySaleControlSaleControlItemsSaleControlItemConditionSaleControl> ConditionSaleControl { get; set; }
                    public class DescribeEnsSaleControlResponseBodySaleControlSaleControlItemsSaleControlItemConditionSaleControl : TeaModel {
                        [NameInMap("ConditionControl")]
                        [Validation(Required=false)]
                        public DescribeEnsSaleControlResponseBodySaleControlSaleControlItemsSaleControlItemConditionSaleControlConditionControl ConditionControl { get; set; }
                        public class DescribeEnsSaleControlResponseBodySaleControlSaleControlItemsSaleControlItemConditionSaleControlConditionControl : TeaModel {
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

                        [NameInMap("ModuleValue")]
                        [Validation(Required=false)]
                        public DescribeEnsSaleControlResponseBodySaleControlSaleControlItemsSaleControlItemConditionSaleControlModuleValue ModuleValue { get; set; }
                        public class DescribeEnsSaleControlResponseBodySaleControlSaleControlItemsSaleControlItemConditionSaleControlModuleValue : TeaModel {
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

                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                    }

                }

            }

        }

    }

}
