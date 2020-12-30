// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeClusterServiceConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeClusterServiceConfigResponseBodyConfig Config { get; set; }
        public class DescribeClusterServiceConfigResponseBodyConfig : TeaModel {
            [NameInMap("Applied")]
            [Validation(Required=false)]
            public string Applied { get; set; }
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("ConfigVersion")]
            [Validation(Required=false)]
            public string ConfigVersion { get; set; }
            [NameInMap("ConfigValueList")]
            [Validation(Required=false)]
            public DescribeClusterServiceConfigResponseBodyConfigConfigValueList ConfigValueList { get; set; }
            public class DescribeClusterServiceConfigResponseBodyConfigConfigValueList : TeaModel {
                [NameInMap("ConfigValue")]
                [Validation(Required=false)]
                public List<DescribeClusterServiceConfigResponseBodyConfigConfigValueListConfigValue> ConfigValue { get; set; }
                public class DescribeClusterServiceConfigResponseBodyConfigConfigValueListConfigValue : TeaModel {
                    [NameInMap("ConfigName")]
                    [Validation(Required=false)]
                    public string ConfigName { get; set; }

                    [NameInMap("ScopeId")]
                    [Validation(Required=false)]
                    public long? ScopeId { get; set; }

                    [NameInMap("ConfigItemValueList")]
                    [Validation(Required=false)]
                    public DescribeClusterServiceConfigResponseBodyConfigConfigValueListConfigValueConfigItemValueList ConfigItemValueList { get; set; }
                    public class DescribeClusterServiceConfigResponseBodyConfigConfigValueListConfigValueConfigItemValueList : TeaModel {
                        [NameInMap("ConfigItemValue")]
                        [Validation(Required=false)]
                        public List<DescribeClusterServiceConfigResponseBodyConfigConfigValueListConfigValueConfigItemValueListConfigItemValue> ConfigItemValue { get; set; }
                        public class DescribeClusterServiceConfigResponseBodyConfigConfigValueListConfigValueConfigItemValueListConfigItemValue : TeaModel {
                            public string Value { get; set; }
                            public string Description { get; set; }
                            public string ItemName { get; set; }
                            public bool? IsCustom { get; set; }
                        }
                    };

                    [NameInMap("AllowCustom")]
                    [Validation(Required=false)]
                    public bool? AllowCustom { get; set; }

                    [NameInMap("Scope")]
                    [Validation(Required=false)]
                    public string Scope { get; set; }

                }

            }
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }
            [NameInMap("PropertyInfoList")]
            [Validation(Required=false)]
            public DescribeClusterServiceConfigResponseBodyConfigPropertyInfoList PropertyInfoList { get; set; }
            public class DescribeClusterServiceConfigResponseBodyConfigPropertyInfoList : TeaModel {
                [NameInMap("PropertyInfo")]
                [Validation(Required=false)]
                public List<DescribeClusterServiceConfigResponseBodyConfigPropertyInfoListPropertyInfo> PropertyInfo { get; set; }
                public class DescribeClusterServiceConfigResponseBodyConfigPropertyInfoListPropertyInfo : TeaModel {
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("PropertyTypes")]
                    [Validation(Required=false)]
                    public DescribeClusterServiceConfigResponseBodyConfigPropertyInfoListPropertyInfoPropertyTypes PropertyTypes { get; set; }
                    public class DescribeClusterServiceConfigResponseBodyConfigPropertyInfoListPropertyInfoPropertyTypes : TeaModel {
                        [NameInMap("propertyType")]
                        [Validation(Required=false)]
                        public List<string> PropertyType { get; set; }
                    };

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("EffectWay")]
                    [Validation(Required=false)]
                    public DescribeClusterServiceConfigResponseBodyConfigPropertyInfoListPropertyInfoEffectWay EffectWay { get; set; }
                    public class DescribeClusterServiceConfigResponseBodyConfigPropertyInfoListPropertyInfoEffectWay : TeaModel {
                        [NameInMap("EffectType")]
                        [Validation(Required=false)]
                        public string EffectType { get; set; }
                        [NameInMap("InvokeServiceName")]
                        [Validation(Required=false)]
                        public string InvokeServiceName { get; set; }
                    };

                    [NameInMap("Component")]
                    [Validation(Required=false)]
                    public string Component { get; set; }

                    [NameInMap("PropertyValueAttributes")]
                    [Validation(Required=false)]
                    public DescribeClusterServiceConfigResponseBodyConfigPropertyInfoListPropertyInfoPropertyValueAttributes PropertyValueAttributes { get; set; }
                    public class DescribeClusterServiceConfigResponseBodyConfigPropertyInfoListPropertyInfoPropertyValueAttributes : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }
                        [NameInMap("Maximum")]
                        [Validation(Required=false)]
                        public string Maximum { get; set; }
                        [NameInMap("Unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }
                        [NameInMap("Hidden")]
                        [Validation(Required=false)]
                        public bool? Hidden { get; set; }
                        [NameInMap("IncrememtStep")]
                        [Validation(Required=false)]
                        public string IncrememtStep { get; set; }
                        [NameInMap("ReadOnly")]
                        [Validation(Required=false)]
                        public bool? ReadOnly { get; set; }
                        [NameInMap("Entries")]
                        [Validation(Required=false)]
                        public DescribeClusterServiceConfigResponseBodyConfigPropertyInfoListPropertyInfoPropertyValueAttributesEntries Entries { get; set; }
                        public class DescribeClusterServiceConfigResponseBodyConfigPropertyInfoListPropertyInfoPropertyValueAttributesEntries : TeaModel {
                            [NameInMap("ValueEntryInfo")]
                            [Validation(Required=false)]
                            public List<DescribeClusterServiceConfigResponseBodyConfigPropertyInfoListPropertyInfoPropertyValueAttributesEntriesValueEntryInfo> ValueEntryInfo { get; set; }
                            public class DescribeClusterServiceConfigResponseBodyConfigPropertyInfoListPropertyInfoPropertyValueAttributesEntriesValueEntryInfo : TeaModel {
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                                [NameInMap("Description")]
                                [Validation(Required=false)]
                                public string Description { get; set; }

                                [NameInMap("Label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                            }

                        }
                        [NameInMap("Mimimum")]
                        [Validation(Required=false)]
                        public string Mimimum { get; set; }
                    };

                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

            }
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }
        };

    }

}
