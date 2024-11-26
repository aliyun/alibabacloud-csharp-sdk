// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        [NameInMap("ActiveAddress")]
        [Validation(Required=false)]
        public string ActiveAddress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;frontEndUrl&quot;:&quot;https://<em><em><b>.aliyundoc.com&quot;,&quot;password&quot;:&quot;Sjtv</b></em>&quot;,&quot;adminUrl&quot;:&quot;https://</em><em><b>.aliyundoc.com&quot;,&quot;username&quot;:&quot;aliyun</b></em>&quot;}</para>
        /// </summary>
        [NameInMap("AppJson")]
        [Validation(Required=false)]
        public string AppJson { get; set; }

        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public string AutoRenewal { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1570634021000</para>
        /// </summary>
        [NameInMap("BeganOn")]
        [Validation(Required=false)]
        public long? BeganOn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;package_version&quot;:&quot;yuncode000111&quot;}</para>
        /// </summary>
        [NameInMap("ComponentJson")]
        [Validation(Required=false)]
        public string ComponentJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public string Constraints { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1570634018000</para>
        /// </summary>
        [NameInMap("CreatedOn")]
        [Validation(Required=false)]
        public long? CreatedOn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1602259200000</para>
        /// </summary>
        [NameInMap("EndOn")]
        [Validation(Required=false)]
        public long? EndOn { get; set; }

        [NameInMap("ExtendJson")]
        [Validation(Required=false)]
        public string ExtendJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;password&quot;:&quot;<em><b>&quot;,&quot;ip&quot;:&quot;118.31.</b></em>.41&quot;,&quot;innerIp&quot;:&quot;118.31.<em><b>.41&quot;,&quot;region&quot;:&quot;&quot;,&quot;username&quot;:&quot;</b></em>&quot;,&quot;beianInfo&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("HostJson")]
        [Validation(Required=false)]
        public string HostJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1551111111</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTrial")]
        [Validation(Required=false)]
        public bool? IsTrial { get; set; }

        [NameInMap("LicenseCode")]
        [Validation(Required=false)]
        public string LicenseCode { get; set; }

        [NameInMap("Modules")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyModules Modules { get; set; }
        public class DescribeInstanceResponseBodyModules : TeaModel {
            [NameInMap("Module")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyModulesModule> Module { get; set; }
            public class DescribeInstanceResponseBodyModulesModule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>package_config</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>101*********026</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Properties")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyModulesModuleProperties Properties { get; set; }
                public class DescribeInstanceResponseBodyModulesModuleProperties : TeaModel {
                    [NameInMap("Property")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceResponseBodyModulesModulePropertiesProperty> Property { get; set; }
                    public class DescribeInstanceResponseBodyModulesModulePropertiesProperty : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>12</para>
                        /// </summary>
                        [NameInMap("DisplayUnit")]
                        [Validation(Required=false)]
                        public string DisplayUnit { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>12</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>12</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("PropertyValues")]
                        [Validation(Required=false)]
                        public DescribeInstanceResponseBodyModulesModulePropertiesPropertyPropertyValues PropertyValues { get; set; }
                        public class DescribeInstanceResponseBodyModulesModulePropertiesPropertyPropertyValues : TeaModel {
                            [NameInMap("PropertyValue")]
                            [Validation(Required=false)]
                            public List<DescribeInstanceResponseBodyModulesModulePropertiesPropertyPropertyValuesPropertyValue> PropertyValue { get; set; }
                            public class DescribeInstanceResponseBodyModulesModulePropertiesPropertyPropertyValuesPropertyValue : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>12</para>
                                /// </summary>
                                [NameInMap("DisplayName")]
                                [Validation(Required=false)]
                                public string DisplayName { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>12</para>
                                /// </summary>
                                [NameInMap("Max")]
                                [Validation(Required=false)]
                                public string Max { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>12</para>
                                /// </summary>
                                [NameInMap("Min")]
                                [Validation(Required=false)]
                                public string Min { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>12</para>
                                /// </summary>
                                [NameInMap("Remark")]
                                [Validation(Required=false)]
                                public string Remark { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>12</para>
                                /// </summary>
                                [NameInMap("Step")]
                                [Validation(Required=false)]
                                public string Step { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>12</para>
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>12</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>12</para>
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
        /// <para>204211111111111</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cmgj00**11</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cmgj00**11-prepay</para>
        /// </summary>
        [NameInMap("ProductSkuCode")]
        [Validation(Required=false)]
        public string ProductSkuCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>APP</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("RelationalData")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyRelationalData RelationalData { get; set; }
        public class DescribeInstanceResponseBodyRelationalData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>STARTED</para>
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OPENED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SupplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

    }

}
