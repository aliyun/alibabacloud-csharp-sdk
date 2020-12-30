// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeConfigIndexResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConfigGroups")]
        [Validation(Required=false)]
        public DescribeConfigIndexResponseBodyConfigGroups ConfigGroups { get; set; }
        public class DescribeConfigIndexResponseBodyConfigGroups : TeaModel {
            [NameInMap("ConfigGroup")]
            [Validation(Required=false)]
            public List<DescribeConfigIndexResponseBodyConfigGroupsConfigGroup> ConfigGroup { get; set; }
            public class DescribeConfigIndexResponseBodyConfigGroupsConfigGroup : TeaModel {
                [NameInMap("ConfigPath")]
                [Validation(Required=false)]
                public List<DescribeConfigIndexResponseBodyConfigGroupsConfigGroupConfigPath> ConfigPath { get; set; }
                public class DescribeConfigIndexResponseBodyConfigGroupsConfigGroupConfigPath : TeaModel {
                    [NameInMap("PathName")]
                    [Validation(Required=false)]
                    public string PathName { get; set; }

                    [NameInMap("HiddenPath")]
                    [Validation(Required=false)]
                    public bool? HiddenPath { get; set; }

                    [NameInMap("ConfigOptions")]
                    [Validation(Required=false)]
                    public DescribeConfigIndexResponseBodyConfigGroupsConfigGroupConfigPathConfigOptions ConfigOptions { get; set; }
                    public class DescribeConfigIndexResponseBodyConfigGroupsConfigGroupConfigPathConfigOptions : TeaModel {
                        [NameInMap("ConfigOption")]
                        [Validation(Required=false)]
                        public List<DescribeConfigIndexResponseBodyConfigGroupsConfigGroupConfigPathConfigOptionsConfigOption> ConfigOption { get; set; }
                        public class DescribeConfigIndexResponseBodyConfigGroupsConfigGroupConfigPathConfigOptionsConfigOption : TeaModel {
                            public string RegexDesc { get; set; }
                            public long? MaxValue { get; set; }
                            public string EditorType { get; set; }
                            public long? MinValue { get; set; }
                            public string OptionLabel { get; set; }
                            public string DefaultValue { get; set; }
                            public int? MaxLength { get; set; }
                            public string RegexPattern { get; set; }
                            public string ChangeSeverity { get; set; }
                            public string OptionDescription { get; set; }
                            public string OptionName { get; set; }
                            public string PathName { get; set; }
                            public bool? HiddenOption { get; set; }
                            public string ValueType { get; set; }
                            public int? MinLength { get; set; }
                            public string ValueOptions { get; set; }
                            public bool? ReadonlyOption { get; set; }
                        }
                    };

                    [NameInMap("PathLabel")]
                    [Validation(Required=false)]
                    public string PathLabel { get; set; }

                }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
