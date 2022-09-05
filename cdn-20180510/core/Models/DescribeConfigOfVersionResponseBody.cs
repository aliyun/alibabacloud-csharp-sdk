// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeConfigOfVersionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VersionConfigs")]
        [Validation(Required=false)]
        public DescribeConfigOfVersionResponseBodyVersionConfigs VersionConfigs { get; set; }
        public class DescribeConfigOfVersionResponseBodyVersionConfigs : TeaModel {
            [NameInMap("VersionConfig")]
            [Validation(Required=false)]
            public List<DescribeConfigOfVersionResponseBodyVersionConfigsVersionConfig> VersionConfig { get; set; }
            public class DescribeConfigOfVersionResponseBodyVersionConfigsVersionConfig : TeaModel {
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                [NameInMap("FunctionArgs")]
                [Validation(Required=false)]
                public DescribeConfigOfVersionResponseBodyVersionConfigsVersionConfigFunctionArgs FunctionArgs { get; set; }
                public class DescribeConfigOfVersionResponseBodyVersionConfigsVersionConfigFunctionArgs : TeaModel {
                    [NameInMap("FunctionArg")]
                    [Validation(Required=false)]
                    public List<DescribeConfigOfVersionResponseBodyVersionConfigsVersionConfigFunctionArgsFunctionArg> FunctionArg { get; set; }
                    public class DescribeConfigOfVersionResponseBodyVersionConfigsVersionConfigFunctionArgsFunctionArg : TeaModel {
                        [NameInMap("ArgName")]
                        [Validation(Required=false)]
                        public string ArgName { get; set; }

                        [NameInMap("ArgValue")]
                        [Validation(Required=false)]
                        public string ArgValue { get; set; }

                    }

                }

                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

    }

}
