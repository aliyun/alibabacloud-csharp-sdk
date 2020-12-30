// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeConfigOptionsResponseBody : TeaModel {
        [NameInMap("StackConfigOption")]
        [Validation(Required=false)]
        public DescribeConfigOptionsResponseBodyStackConfigOption StackConfigOption { get; set; }
        public class DescribeConfigOptionsResponseBodyStackConfigOption : TeaModel {
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }
            [NameInMap("ConfigOptions")]
            [Validation(Required=false)]
            public DescribeConfigOptionsResponseBodyStackConfigOptionConfigOptions ConfigOptions { get; set; }
            public class DescribeConfigOptionsResponseBodyStackConfigOptionConfigOptions : TeaModel {
                [NameInMap("ConfigOption")]
                [Validation(Required=false)]
                public List<DescribeConfigOptionsResponseBodyStackConfigOptionConfigOptionsConfigOption> ConfigOption { get; set; }
                public class DescribeConfigOptionsResponseBodyStackConfigOptionConfigOptionsConfigOption : TeaModel {
                    [NameInMap("RegexDesc")]
                    [Validation(Required=false)]
                    public string RegexDesc { get; set; }

                    [NameInMap("MaxValue")]
                    [Validation(Required=false)]
                    public long? MaxValue { get; set; }

                    [NameInMap("EditorType")]
                    [Validation(Required=false)]
                    public string EditorType { get; set; }

                    [NameInMap("MinValue")]
                    [Validation(Required=false)]
                    public long? MinValue { get; set; }

                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    [NameInMap("MaxLength")]
                    [Validation(Required=false)]
                    public int? MaxLength { get; set; }

                    [NameInMap("OptionLabel")]
                    [Validation(Required=false)]
                    public string OptionLabel { get; set; }

                    [NameInMap("RegexPattern")]
                    [Validation(Required=false)]
                    public string RegexPattern { get; set; }

                    [NameInMap("ChangeSeverity")]
                    [Validation(Required=false)]
                    public string ChangeSeverity { get; set; }

                    [NameInMap("OptionDescription")]
                    [Validation(Required=false)]
                    public string OptionDescription { get; set; }

                    [NameInMap("OptionName")]
                    [Validation(Required=false)]
                    public string OptionName { get; set; }

                    [NameInMap("PathName")]
                    [Validation(Required=false)]
                    public string PathName { get; set; }

                    [NameInMap("HiddenOption")]
                    [Validation(Required=false)]
                    public bool? HiddenOption { get; set; }

                    [NameInMap("ValueType")]
                    [Validation(Required=false)]
                    public string ValueType { get; set; }

                    [NameInMap("MinLength")]
                    [Validation(Required=false)]
                    public int? MinLength { get; set; }

                    [NameInMap("ValueOptions")]
                    [Validation(Required=false)]
                    public string ValueOptions { get; set; }

                    [NameInMap("ReadonlyOption")]
                    [Validation(Required=false)]
                    public bool? ReadonlyOption { get; set; }

                }

            }
            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
