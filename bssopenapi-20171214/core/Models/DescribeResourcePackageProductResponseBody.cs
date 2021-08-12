// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourcePackageProductResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResourcePackageProductResponseBodyData Data { get; set; }
        public class DescribeResourcePackageProductResponseBodyData : TeaModel {
            [NameInMap("ResourcePackages")]
            [Validation(Required=false)]
            public DescribeResourcePackageProductResponseBodyDataResourcePackages ResourcePackages { get; set; }
            public class DescribeResourcePackageProductResponseBodyDataResourcePackages : TeaModel {
                [NameInMap("ResourcePackage")]
                [Validation(Required=false)]
                public List<DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackage> ResourcePackage { get; set; }
                public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackage : TeaModel {
                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    [NameInMap("PackageTypes")]
                    [Validation(Required=false)]
                    public DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypes PackageTypes { get; set; }
                    public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypes : TeaModel {
                        [NameInMap("PackageType")]
                        [Validation(Required=false)]
                        public List<DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageType> PackageType { get; set; }
                        public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageType : TeaModel {
                            public string Code { get; set; }
                            public string Name { get; set; }
                            public DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeProperties Properties { get; set; }
                            public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeProperties : TeaModel {
                                [NameInMap("Property")]
                                [Validation(Required=false)]
                                public List<DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypePropertiesProperty> Property { get; set; }
                                public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypePropertiesProperty : TeaModel {
                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                            }
                            public DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecifications Specifications { get; set; }
                            public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecifications : TeaModel {
                                [NameInMap("Specification")]
                                [Validation(Required=false)]
                                public List<DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecification> Specification { get; set; }
                                public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecification : TeaModel {
                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                    [NameInMap("AvailableDurations")]
                                    [Validation(Required=false)]
                                    public DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecificationAvailableDurations AvailableDurations { get; set; }
                                    public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecificationAvailableDurations : TeaModel {
                                        [NameInMap("AvailableDuration")]
                                        [Validation(Required=false)]
                                        public List<DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecificationAvailableDurationsAvailableDuration> AvailableDuration { get; set; }
                                        public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecificationAvailableDurationsAvailableDuration : TeaModel {
                                            public int? Value { get; set; }
                                            public string Name { get; set; }
                                            public string Unit { get; set; }
                                        }
                                    };

                                }

                            }
                        }
                    };

                }

            }
        };

    }

}
