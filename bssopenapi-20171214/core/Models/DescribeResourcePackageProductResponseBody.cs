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
            [NameInMap("ResourcePackages")]
            [Validation(Required=false)]
            public DescribeResourcePackageProductResponseBodyDataResourcePackages ResourcePackages { get; set; }
            public class DescribeResourcePackageProductResponseBodyDataResourcePackages : TeaModel {
                [NameInMap("ResourcePackage")]
                [Validation(Required=false)]
                public List<DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackage> ResourcePackage { get; set; }
                public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackage : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("PackageTypes")]
                    [Validation(Required=false)]
                    public DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypes PackageTypes { get; set; }
                    public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypes : TeaModel {
                        [NameInMap("PackageType")]
                        [Validation(Required=false)]
                        public List<DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageType> PackageType { get; set; }
                        public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageType : TeaModel {
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public string Code { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("Properties")]
                            [Validation(Required=false)]
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

                            [NameInMap("Specifications")]
                            [Validation(Required=false)]
                            public DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecifications Specifications { get; set; }
                            public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecifications : TeaModel {
                                [NameInMap("Specification")]
                                [Validation(Required=false)]
                                public List<DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecification> Specification { get; set; }
                                public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecification : TeaModel {
                                    [NameInMap("AvailableDurations")]
                                    [Validation(Required=false)]
                                    public DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecificationAvailableDurations AvailableDurations { get; set; }
                                    public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecificationAvailableDurations : TeaModel {
                                        [NameInMap("AvailableDuration")]
                                        [Validation(Required=false)]
                                        public List<DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecificationAvailableDurationsAvailableDuration> AvailableDuration { get; set; }
                                        public class DescribeResourcePackageProductResponseBodyDataResourcePackagesResourcePackagePackageTypesPackageTypeSpecificationsSpecificationAvailableDurationsAvailableDuration : TeaModel {
                                            [NameInMap("Name")]
                                            [Validation(Required=false)]
                                            public string Name { get; set; }

                                            [NameInMap("Unit")]
                                            [Validation(Required=false)]
                                            public string Unit { get; set; }

                                            [NameInMap("Value")]
                                            [Validation(Required=false)]
                                            public int? Value { get; set; }

                                        }

                                    }

                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                            }

                        }

                    }

                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

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
