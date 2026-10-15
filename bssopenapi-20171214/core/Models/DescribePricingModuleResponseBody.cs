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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePricingModuleResponseBodyData Data { get; set; }
        public class DescribePricingModuleResponseBodyData : TeaModel {
            [NameInMap("AttributeList")]
            [Validation(Required=false)]
            public DescribePricingModuleResponseBodyDataAttributeList AttributeList { get; set; }
            public class DescribePricingModuleResponseBodyDataAttributeList : TeaModel {
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public List<DescribePricingModuleResponseBodyDataAttributeListAttribute> Attribute { get; set; }
                public class DescribePricingModuleResponseBodyDataAttributeListAttribute : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public DescribePricingModuleResponseBodyDataAttributeListAttributeValues Values { get; set; }
                    public class DescribePricingModuleResponseBodyDataAttributeListAttributeValues : TeaModel {
                        [NameInMap("AttributeValue")]
                        [Validation(Required=false)]
                        public List<DescribePricingModuleResponseBodyDataAttributeListAttributeValuesAttributeValue> AttributeValue { get; set; }
                        public class DescribePricingModuleResponseBodyDataAttributeListAttributeValuesAttributeValue : TeaModel {
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("Remark")]
                            [Validation(Required=false)]
                            public string Remark { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                }

            }

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

                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    [NameInMap("ModuleCode")]
                    [Validation(Required=false)]
                    public string ModuleCode { get; set; }

                    [NameInMap("ModuleName")]
                    [Validation(Required=false)]
                    public string ModuleName { get; set; }

                    [NameInMap("PriceType")]
                    [Validation(Required=false)]
                    public string PriceType { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This API is not applicable for caller.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C40A8EE0-8084-49FE-B66E-5E1C3B6AE025</para>
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
