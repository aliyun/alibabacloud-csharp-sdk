// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribePricingModuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
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
        public DescribePricingModuleResponseBodyData Data { get; set; }
        public class DescribePricingModuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The module attributes.</para>
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
                    /// <para>The code of the attribute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DBInstanceStorage</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The name of the attribute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Capacity</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the attribute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GB</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The attribute values.</para>
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
                            /// <para>The attribute value that corresponds to the module code.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2 Cores and 4 GB Memory (Basic Edition)</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The description of the module values.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Connections: 4,000 IOPS is related to storage space</para>
                            /// </summary>
                            [NameInMap("Remark")]
                            [Validation(Required=false)]
                            public string Remark { get; set; }

                            /// <summary>
                            /// <para>The type of the attribute value that corresponds to the module code. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>single_float: single value</description></item>
                            /// <item><description>range_float: range value</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>single_string</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>The attribute value that corresponds to the module code.</para>
                            /// <remarks>
                            /// <para> If the Type parameter is set to range_float, the valid values of this parameter range from 1024 to 1024000. A value of 1024 indicates that the step size is 1024.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>mysql.n2.medium.1</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                }

            }

            /// <summary>
            /// <para>The pricing information of modules.</para>
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
                    /// <para>The currency. Default value: CNY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CNY</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <para>The code of the pricing module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>InstanceType</para>
                    /// </summary>
                    [NameInMap("ModuleCode")]
                    [Validation(Required=false)]
                    public string ModuleCode { get; set; }

                    /// <summary>
                    /// <para>The name of the pricing module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Instance</para>
                    /// </summary>
                    [NameInMap("ModuleName")]
                    [Validation(Required=false)]
                    public string ModuleName { get; set; }

                    /// <summary>
                    /// <para>The price type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Usage: usage price</description></item>
                    /// <item><description>Hour: hourly price</description></item>
                    /// <item><description>Day: daily price</description></item>
                    /// <item><description>Week: weekly price</description></item>
                    /// <item><description>Month: monthly price</description></item>
                    /// <item><description>Year: annual price</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Month</para>
                    /// </summary>
                    [NameInMap("PriceType")]
                    [Validation(Required=false)]
                    public string PriceType { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This API is not applicable for caller.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C40A8EE0-8084-49FE-B66E-5E1C3B6AE025</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
