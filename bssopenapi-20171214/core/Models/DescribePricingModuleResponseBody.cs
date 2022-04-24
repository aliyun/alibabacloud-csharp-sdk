// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribePricingModuleResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
                            public string Name { get; set; }
                            public string Remark { get; set; }
                            public string Type { get; set; }
                            public string Value { get; set; }
                        }
                    };

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
                    };

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
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
