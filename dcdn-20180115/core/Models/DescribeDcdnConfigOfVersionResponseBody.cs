// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnConfigOfVersionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VersionConfigs")]
        [Validation(Required=false)]
        public DescribeDcdnConfigOfVersionResponseBodyVersionConfigs VersionConfigs { get; set; }
        public class DescribeDcdnConfigOfVersionResponseBodyVersionConfigs : TeaModel {
            [NameInMap("VersionConfig")]
            [Validation(Required=false)]
            public List<DescribeDcdnConfigOfVersionResponseBodyVersionConfigsVersionConfig> VersionConfig { get; set; }
            public class DescribeDcdnConfigOfVersionResponseBodyVersionConfigsVersionConfig : TeaModel {
                public string Status { get; set; }
                public string ConfigId { get; set; }
                public string FunctionName { get; set; }
                public DescribeDcdnConfigOfVersionResponseBodyVersionConfigsVersionConfigFunctionArgs FunctionArgs { get; set; }
                public class DescribeDcdnConfigOfVersionResponseBodyVersionConfigsVersionConfigFunctionArgs : TeaModel {
                    [NameInMap("FunctionArg")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnConfigOfVersionResponseBodyVersionConfigsVersionConfigFunctionArgsFunctionArg> FunctionArg { get; set; }
                    public class DescribeDcdnConfigOfVersionResponseBodyVersionConfigsVersionConfigFunctionArgsFunctionArg : TeaModel {
                        [NameInMap("ArgName")]
                        [Validation(Required=false)]
                        public string ArgName { get; set; }

                        [NameInMap("ArgValue")]
                        [Validation(Required=false)]
                        public string ArgValue { get; set; }

                    }

                }
            }
        };

    }

}
