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

        /// <summary>
        /// <b>Example:</b>
        /// <para>function_fail</para>
        /// </summary>
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public string AuditStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1581609600000</para>
        /// </summary>
        [NameInMap("AuditTime")]
        [Validation(Required=false)]
        public long? AuditTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cmjj01**45</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>523617212</para>
        /// </summary>
        [NameInMap("FrontCategoryId")]
        [Validation(Required=false)]
        public long? FrontCategoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1578931200000</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public long? GmtCreated { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1578931200000</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://oss.aliyuncs.com/photogallery/photo/1930532890589852/6245/495d5f19-03e4-4c2e-9c4e-bef9ab6af1e1.png">https://oss.aliyuncs.com/photogallery/photo/1930532890589852/6245/495d5f19-03e4-4c2e-9c4e-bef9ab6af1e1.png</a></para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>product_advantage</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HTML</para>
                /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>PREPAY</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cmjj01****-Package</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;img_id\&quot;:{\&quot;img_version|img_region\&quot;:{\&quot;V1.7|cn-shenzhen-st3-a01\&quot;:[\&quot;m-wz9ho4hmos0lpxcldqoq\&quot;]}}</para>
                /// </summary>
                [NameInMap("Constraints")]
                [Validation(Required=false)]
                public string Constraints { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>img_id</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>248220</para>
                        /// </summary>
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
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("DisplayUnit")]
                                [Validation(Required=false)]
                                public string DisplayUnit { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>img_id</para>
                                /// </summary>
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

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>123</para>
                                        /// </summary>
                                        [NameInMap("Max")]
                                        [Validation(Required=false)]
                                        public string Max { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>11</para>
                                        /// </summary>
                                        [NameInMap("Min")]
                                        [Validation(Required=false)]
                                        public string Min { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>abc</para>
                                        /// </summary>
                                        [NameInMap("Remark")]
                                        [Validation(Required=false)]
                                        public string Remark { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Step")]
                                        [Validation(Required=false)]
                                        public string Step { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>single_string</para>
                                        /// </summary>
                                        [NameInMap("Type")]
                                        [Validation(Required=false)]
                                        public string Type { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>m-28e213e7t</para>
                                        /// </summary>
                                        [NameInMap("Value")]
                                        [Validation(Required=false)]
                                        public string Value { get; set; }

                                    }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>number</para>
                                /// </summary>
                                [NameInMap("ShowType")]
                                [Validation(Required=false)]
                                public string ShowType { get; set; }

                            }

                        }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>HOUR</para>
                        /// </summary>
                        [NameInMap("PeriodType")]
                        [Validation(Required=false)]
                        public string PeriodType { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6EF60BEC-0242-43AF-BB20-270359FB54A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("Score")]
        [Validation(Required=false)]
        public float? Score { get; set; }

        [NameInMap("ShopInfo")]
        [Validation(Required=false)]
        public DescribeProductResponseBodyShopInfo ShopInfo { get; set; }
        public class DescribeProductResponseBodyShopInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>46**<a href="mailto:41@example.com">41@example.com</a></para>
            /// </summary>
            [NameInMap("Emails")]
            [Validation(Required=false)]
            public string Emails { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ABC</para>
                    /// </summary>
                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

            }

        }

        [NameInMap("ShortDescription")]
        [Validation(Required=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1526111111****</para>
        /// </summary>
        [NameInMap("SupplierPk")]
        [Validation(Required=false)]
        public long? SupplierPk { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MIRROR</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UseCount")]
        [Validation(Required=false)]
        public long? UseCount { get; set; }

    }

}
