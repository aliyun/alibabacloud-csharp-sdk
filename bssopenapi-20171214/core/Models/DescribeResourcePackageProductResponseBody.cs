// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourcePackageProductResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResourcePackageProductResponseBodyData Data { get; set; }
        public class DescribeResourcePackageProductResponseBodyData : TeaModel {
            /// <summary>
            /// The details about the resource plans.
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
                    /// The name of the resource plan.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The types of the resource plans.
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
                            /// The code of the resource plan.
                            /// </summary>
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public string Code { get; set; }

                            /// <summary>
                            /// The name of the resource plan type.
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// The properties of the resource plan.
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
                                    /// The name of the property.
                                    /// </summary>
                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    /// <summary>
                                    /// The value of the property.
                                    /// </summary>
                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                            }

                            /// <summary>
                            /// The specifications of the resource plan.
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
                                    /// The validity periods available for the resource plan.
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
                                            /// The name of the validity period.
                                            /// </summary>
                                            [NameInMap("Name")]
                                            [Validation(Required=false)]
                                            public string Name { get; set; }

                                            /// <summary>
                                            /// The unit of the validity period for the resource plan. Valid values:
                                            /// 
                                            /// *   Month
                                            /// *   Year
                                            /// 
                                            /// Default value: Month.
                                            /// </summary>
                                            [NameInMap("Unit")]
                                            [Validation(Required=false)]
                                            public string Unit { get; set; }

                                            /// <summary>
                                            /// The value of the validity period.
                                            /// </summary>
                                            [NameInMap("Value")]
                                            [Validation(Required=false)]
                                            public int? Value { get; set; }

                                        }

                                    }

                                    /// <summary>
                                    /// The name of the specification.
                                    /// </summary>
                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    /// <summary>
                                    /// The value of the specification.
                                    /// </summary>
                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                            }

                        }

                    }

                    /// <summary>
                    /// The code of the service.
                    /// </summary>
                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    /// <summary>
                    /// The type of the service.
                    /// </summary>
                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                }

            }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the order.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
