// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribePricingModuleResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePricingModuleResponseBodyData Data { get; set; }
        public class DescribePricingModuleResponseBodyData : TeaModel {
            /// <summary>
            /// The module attributes.
            /// </summary>
            [NameInMap("AttributeList")]
            [Validation(Required=false)]
            public DescribePricingModuleResponseBodyDataAttributeList AttributeList { get; set; }
            public class DescribePricingModuleResponseBodyDataAttributeList : TeaModel {
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public List<DescribePricingModuleResponseBodyDataAttributeListAttribute> Attribute { get; set; }
                public class DescribePricingModuleResponseBodyDataAttributeListAttribute : TeaModel {
                    /// <summary>
                    /// The code of the attribute.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// The name of the attribute.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the attribute.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The attribute values.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public DescribePricingModuleResponseBodyDataAttributeListAttributeValues Values { get; set; }
                    public class DescribePricingModuleResponseBodyDataAttributeListAttributeValues : TeaModel {
                        [NameInMap("AttributeValue")]
                        [Validation(Required=false)]
                        public List<DescribePricingModuleResponseBodyDataAttributeListAttributeValuesAttributeValue> AttributeValue { get; set; }
                        public class DescribePricingModuleResponseBodyDataAttributeListAttributeValuesAttributeValue : TeaModel {
                            /// <summary>
                            /// The attribute value that corresponds to the module code.
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// The description of the module values.
                            /// </summary>
                            [NameInMap("Remark")]
                            [Validation(Required=false)]
                            public string Remark { get; set; }

                            /// <summary>
                            /// The type of the attribute value that corresponds to the module code. Valid values:
                            /// 
                            /// *   single_float: single value
                            /// *   range_float: range value
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// The attribute value that corresponds to the module code.
                            /// 
                            /// >  If the Type parameter is set to range_float, the valid values of this parameter range from 1024 to 1024000. A value of 1024 indicates that the step size is 1024.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                }

            }

            /// <summary>
            /// The pricing information of modules.
            /// </summary>
            [NameInMap("ModuleList")]
            [Validation(Required=false)]
            public DescribePricingModuleResponseBodyDataModuleList ModuleList { get; set; }
            public class DescribePricingModuleResponseBodyDataModuleList : TeaModel {
                [NameInMap("Module")]
                [Validation(Required=false)]
                public List<DescribePricingModuleResponseBodyDataModuleListModule> Module { get; set; }
                public class DescribePricingModuleResponseBodyDataModuleListModule : TeaModel {
                    [NameInMap("ConfigList")]
                    [Validation(Required=false)]
                    public DescribePricingModuleResponseBodyDataModuleListModuleConfigList ConfigList { get; set; }
                    public class DescribePricingModuleResponseBodyDataModuleListModuleConfigList : TeaModel {
                        [NameInMap("ConfigList")]
                        [Validation(Required=false)]
                        public List<string> ConfigList { get; set; }

                    }

                    /// <summary>
                    /// The currency. Default value: CNY.
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// The code of the pricing module.
                    /// </summary>
                    [NameInMap("ModuleCode")]
                    [Validation(Required=false)]
                    public string ModuleCode { get; set; }

                    /// <summary>
                    /// The name of the pricing module.
                    /// </summary>
                    [NameInMap("ModuleName")]
                    [Validation(Required=false)]
                    public string ModuleName { get; set; }

                    /// <summary>
                    /// The price type. Valid values:
                    /// 
                    /// *   Usage: usage price
                    /// *   Hour: hourly price
                    /// *   Day: daily price
                    /// *   Week: weekly price
                    /// *   Month: monthly price
                    /// *   Year: annual price
                    /// </summary>
                    [NameInMap("PriceType")]
                    [Validation(Required=false)]
                    public string PriceType { get; set; }

                }

            }

        }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
