// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeProductResponseBody : TeaModel {
        [NameInMap("AuditFailMsg")]
        [Validation(Required=false)]
        public string AuditFailMsg { get; set; }

        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public string AuditStatus { get; set; }

        [NameInMap("AuditTime")]
        [Validation(Required=false)]
        public long? AuditTime { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FrontCategoryId")]
        [Validation(Required=false)]
        public long? FrontCategoryId { get; set; }

        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public long? GmtCreated { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PicUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

        [NameInMap("ProductExtras")]
        [Validation(Required=false)]
        public DescribeProductResponseBodyProductExtras ProductExtras { get; set; }
        public class DescribeProductResponseBodyProductExtras : TeaModel {
            [NameInMap("ProductExtra")]
            [Validation(Required=false)]
            public List<DescribeProductResponseBodyProductExtrasProductExtra> ProductExtra { get; set; }
            public class DescribeProductResponseBodyProductExtrasProductExtra : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public string Values { get; set; }

            }

        }

        [NameInMap("ProductSkus")]
        [Validation(Required=false)]
        public DescribeProductResponseBodyProductSkus ProductSkus { get; set; }
        public class DescribeProductResponseBodyProductSkus : TeaModel {
            [NameInMap("ProductSku")]
            [Validation(Required=false)]
            public List<DescribeProductResponseBodyProductSkusProductSku> ProductSku { get; set; }
            public class DescribeProductResponseBodyProductSkusProductSku : TeaModel {
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Constraints")]
                [Validation(Required=false)]
                public string Constraints { get; set; }

                [NameInMap("Hidden")]
                [Validation(Required=false)]
                public bool? Hidden { get; set; }

                [NameInMap("Modules")]
                [Validation(Required=false)]
                public DescribeProductResponseBodyProductSkusProductSkuModules Modules { get; set; }
                public class DescribeProductResponseBodyProductSkusProductSkuModules : TeaModel {
                    [NameInMap("Module")]
                    [Validation(Required=false)]
                    public List<DescribeProductResponseBodyProductSkusProductSkuModulesModule> Module { get; set; }
                    public class DescribeProductResponseBodyProductSkusProductSkuModulesModule : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Properties")]
                        [Validation(Required=false)]
                        public DescribeProductResponseBodyProductSkusProductSkuModulesModuleProperties Properties { get; set; }
                        public class DescribeProductResponseBodyProductSkusProductSkuModulesModuleProperties : TeaModel {
                            [NameInMap("Property")]
                            [Validation(Required=false)]
                            public List<DescribeProductResponseBodyProductSkusProductSkuModulesModulePropertiesProperty> Property { get; set; }
                            public class DescribeProductResponseBodyProductSkusProductSkuModulesModulePropertiesProperty : TeaModel {
                                [NameInMap("DisplayUnit")]
                                [Validation(Required=false)]
                                public string DisplayUnit { get; set; }

                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                [NameInMap("PropertyValues")]
                                [Validation(Required=false)]
                                public DescribeProductResponseBodyProductSkusProductSkuModulesModulePropertiesPropertyPropertyValues PropertyValues { get; set; }
                                public class DescribeProductResponseBodyProductSkusProductSkuModulesModulePropertiesPropertyPropertyValues : TeaModel {
                                    [NameInMap("PropertyValue")]
                                    [Validation(Required=false)]
                                    public List<DescribeProductResponseBodyProductSkusProductSkuModulesModulePropertiesPropertyPropertyValuesPropertyValue> PropertyValue { get; set; }
                                    public class DescribeProductResponseBodyProductSkusProductSkuModulesModulePropertiesPropertyPropertyValuesPropertyValue : TeaModel {
                                        [NameInMap("DisplayName")]
                                        [Validation(Required=false)]
                                        public string DisplayName { get; set; }

                                        [NameInMap("Max")]
                                        [Validation(Required=false)]
                                        public string Max { get; set; }

                                        [NameInMap("Min")]
                                        [Validation(Required=false)]
                                        public string Min { get; set; }

                                        [NameInMap("Remark")]
                                        [Validation(Required=false)]
                                        public string Remark { get; set; }

                                        [NameInMap("Step")]
                                        [Validation(Required=false)]
                                        public string Step { get; set; }

                                        [NameInMap("Type")]
                                        [Validation(Required=false)]
                                        public string Type { get; set; }

                                        [NameInMap("Value")]
                                        [Validation(Required=false)]
                                        public string Value { get; set; }

                                    }

                                }

                                [NameInMap("ShowType")]
                                [Validation(Required=false)]
                                public string ShowType { get; set; }

                            }

                        }

                    }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OrderPeriods")]
                [Validation(Required=false)]
                public DescribeProductResponseBodyProductSkusProductSkuOrderPeriods OrderPeriods { get; set; }
                public class DescribeProductResponseBodyProductSkusProductSkuOrderPeriods : TeaModel {
                    [NameInMap("OrderPeriod")]
                    [Validation(Required=false)]
                    public List<DescribeProductResponseBodyProductSkusProductSkuOrderPeriodsOrderPeriod> OrderPeriod { get; set; }
                    public class DescribeProductResponseBodyProductSkusProductSkuOrderPeriodsOrderPeriod : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("PeriodType")]
                        [Validation(Required=false)]
                        public string PeriodType { get; set; }

                    }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Score")]
        [Validation(Required=false)]
        public float? Score { get; set; }

        [NameInMap("ShopInfo")]
        [Validation(Required=false)]
        public DescribeProductResponseBodyShopInfo ShopInfo { get; set; }
        public class DescribeProductResponseBodyShopInfo : TeaModel {
            [NameInMap("Emails")]
            [Validation(Required=false)]
            public string Emails { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Telephones")]
            [Validation(Required=false)]
            public DescribeProductResponseBodyShopInfoTelephones Telephones { get; set; }
            public class DescribeProductResponseBodyShopInfoTelephones : TeaModel {
                [NameInMap("Telephone")]
                [Validation(Required=false)]
                public List<string> Telephone { get; set; }

            }

            [NameInMap("WangWangs")]
            [Validation(Required=false)]
            public DescribeProductResponseBodyShopInfoWangWangs WangWangs { get; set; }
            public class DescribeProductResponseBodyShopInfoWangWangs : TeaModel {
                [NameInMap("WangWang")]
                [Validation(Required=false)]
                public List<DescribeProductResponseBodyShopInfoWangWangsWangWang> WangWang { get; set; }
                public class DescribeProductResponseBodyShopInfoWangWangsWangWang : TeaModel {
                    [NameInMap("Remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

            }

        }

        [NameInMap("ShortDescription")]
        [Validation(Required=false)]
        public string ShortDescription { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SupplierPk")]
        [Validation(Required=false)]
        public long? SupplierPk { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UseCount")]
        [Validation(Required=false)]
        public long? UseCount { get; set; }

    }

}
