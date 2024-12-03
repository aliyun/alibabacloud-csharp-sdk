// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourcePackageProductResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResourcePackageProductResponseBodyData Data { get; set; }
        public class DescribeResourcePackageProductResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details about the resource plans.</para>
            /// </summary>
            [NameInMap("ResourcePackages")]
            [Validation(Required=false)]
            public DescribeResourcePackageProductResponseBodyDataResourcePackages ResourcePackages { get; set; }
            public class DescribeResourcePackageProductResponseBodyDataResourcePackages : TeaModel {
                [NameInMap("ResourcePackage")]
                [Validation(Required=false)]
                public List<DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackage> ResourcePackage { get; set; }
                public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackage : TeaModel {
                    /// <summary>
                    /// <para>The name of the resource plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Object Storage Service (OSS) resource plan (monthly)</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The types of the resource plans.</para>
                    /// </summary>
                    [NameInMap("PackageTypes")]
                    [Validation(Required=false)]
                    public DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypes PackageTypes { get; set; }
                    public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypes : TeaModel {
                        [NameInMap("PackageType")]
                        [Validation(Required=false)]
                        public List<DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageType> PackageType { get; set; }
                        public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageType : TeaModel {
                            /// <summary>
                            /// <para>The code of the resource plan.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>FPT_ossbag_deadlineAcc_CdnOut_common_sz</para>
                            /// </summary>
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public string Code { get; set; }

                            /// <summary>
                            /// <para>The name of the resource plan type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Back-to-origin traffic plan - China (Shenzhen)</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The properties of the resource plan.</para>
                            /// </summary>
                            [NameInMap("Properties")]
                            [Validation(Required=false)]
                            public DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeProperties Properties { get; set; }
                            public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeProperties : TeaModel {
                                [NameInMap("Property")]
                                [Validation(Required=false)]
                                public List<DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypePropertiesProperty> Property { get; set; }
                                public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypePropertiesProperty : TeaModel {
                                    /// <summary>
                                    /// <para>The name of the property.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>region</para>
                                    /// </summary>
                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    /// <summary>
                                    /// <para>The value of the property.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>cn-shenzhen</para>
                                    /// </summary>
                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>The specifications of the resource plan.</para>
                            /// </summary>
                            [NameInMap("Specifications")]
                            [Validation(Required=false)]
                            public DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecifications Specifications { get; set; }
                            public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecifications : TeaModel {
                                [NameInMap("Specification")]
                                [Validation(Required=false)]
                                public List<DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecification> Specification { get; set; }
                                public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecification : TeaModel {
                                    /// <summary>
                                    /// <para>The validity periods available for the resource plan.</para>
                                    /// </summary>
                                    [NameInMap("AvailableDurations")]
                                    [Validation(Required=false)]
                                    public DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecificationAvailableDurations AvailableDurations { get; set; }
                                    public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecificationAvailableDurations : TeaModel {
                                        [NameInMap("AvailableDuration")]
                                        [Validation(Required=false)]
                                        public List<DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecificationAvailableDurationsAvailableDuration> AvailableDuration { get; set; }
                                        public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecificationAvailableDurationsAvailableDuration : TeaModel {
                                            /// <summary>
                                            /// <para>The name of the validity period.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>6 Month</para>
                                            /// </summary>
                                            [NameInMap("Name")]
                                            [Validation(Required=false)]
                                            public string Name { get; set; }

                                            /// <summary>
                                            /// <para>The unit of the validity period for the resource plan. Valid values:</para>
                                            /// <list type="bullet">
                                            /// <item><description>Month</description></item>
                                            /// <item><description>Year</description></item>
                                            /// </list>
                                            /// <para>Default value: Month.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>Month</para>
                                            /// </summary>
                                            [NameInMap("Unit")]
                                            [Validation(Required=false)]
                                            public string Unit { get; set; }

                                            /// <summary>
                                            /// <para>The value of the validity period.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>6</para>
                                            /// </summary>
                                            [NameInMap("Value")]
                                            [Validation(Required=false)]
                                            public int? Value { get; set; }

                                        }

                                    }

                                    /// <summary>
                                    /// <para>The name of the specification.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1TB</para>
                                    /// </summary>
                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    /// <summary>
                                    /// <para>The value of the specification.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1024</para>
                                    /// </summary>
                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                            }

                        }

                    }

                    /// <summary>
                    /// <para>The code of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ossbag</para>
                    /// </summary>
                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    /// <summary>
                    /// <para>The type of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ossbag</para>
                    /// </summary>
                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72353765387</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBEF51A3-E933-4F40-A534-C673CBDB9C80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
