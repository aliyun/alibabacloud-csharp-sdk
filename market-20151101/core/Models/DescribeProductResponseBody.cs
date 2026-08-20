// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeProductResponseBody : TeaModel {
        /// <summary>
        /// <para>The reason for the audit failure. This parameter is returned when QueryDraft is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>功能验收不通过</para>
        /// </summary>
        [NameInMap("AuditFailMsg")]
        [Validation(Required=false)]
        public string AuditFailMsg { get; set; }

        /// <summary>
        /// <para>The audit status. This parameter is returned when QueryDraft is set to true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>draft: not submitted</description></item>
        /// <item><description>security_ing: security audit in progress</description></item>
        /// <item><description>security_fail: security audit failed</description></item>
        /// <item><description>function_ing: functional audit in progress</description></item>
        /// <item><description>function_fail: functional audit failed</description></item>
        /// <item><description>info_ing: product information audit in progress</description></item>
        /// <item><description>info_fail: product information audit failed</description></item>
        /// <item><description>success: succeeded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>function_fail</para>
        /// </summary>
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public string AuditStatus { get; set; }

        /// <summary>
        /// <para>The audit time. This parameter is returned when QueryDraft is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1581609600000</para>
        /// </summary>
        [NameInMap("AuditTime")]
        [Validation(Required=false)]
        public long? AuditTime { get; set; }

        /// <summary>
        /// <para>The commodity code of the product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cmjj01**45</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detailed description of the product. HTML is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <div>基于阿里云（Ubuntu16.04 64位）系统源码安装，安全、稳定、高效！</div>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The product category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>523617212</para>
        /// </summary>
        [NameInMap("FrontCategoryId")]
        [Validation(Required=false)]
        public long? FrontCategoryId { get; set; }

        /// <summary>
        /// <para>The time when the product was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1578931200000</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public long? GmtCreated { get; set; }

        /// <summary>
        /// <para>The time when the product was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1578931200000</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <para>The product name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LNMP环境（Ubuntu16.04 Nginx PHP5.3）</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The URL of the product image.</para>
        /// 
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EF60BEC-0242-43AF-BB20-270359FB54A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The product rating.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("Score")]
        [Validation(Required=false)]
        public float? Score { get; set; }

        /// <summary>
        /// <para>The shop information.</para>
        /// </summary>
        [NameInMap("ShopInfo")]
        [Validation(Required=false)]
        public DescribeProductResponseBodyShopInfo ShopInfo { get; set; }
        public class DescribeProductResponseBodyShopInfo : TeaModel {
            /// <summary>
            /// <para>The email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46**<a href="mailto:41@example.com">41@example.com</a></para>
            /// </summary>
            [NameInMap("Emails")]
            [Validation(Required=false)]
            public string Emails { get; set; }

            /// <summary>
            /// <para>The shop ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The shop name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>**科学公司</para>
            /// </summary>
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

        /// <summary>
        /// <para>The short description of the product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>该镜像为LNMP（Ubuntu16.04 64位+Nginx+MySQL5.6+PHP5.3）</para>
        /// </summary>
        [NameInMap("ShortDescription")]
        [Validation(Required=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// <para>Deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The UID of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1526111111****</para>
        /// </summary>
        [NameInMap("SupplierPk")]
        [Validation(Required=false)]
        public long? SupplierPk { get; set; }

        /// <summary>
        /// <para>The product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>APP: application</description></item>
        /// <item><description>DOWNLOAD: download</description></item>
        /// <item><description>MIRROR: image</description></item>
        /// <item><description>SERVICE: service</description></item>
        /// <item><description>API_SERVICE: API service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MIRROR</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The usage count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UseCount")]
        [Validation(Required=false)]
        public long? UseCount { get; set; }

    }

}
