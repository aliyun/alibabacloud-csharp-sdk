// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpaDomainConfigsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public DescribeDcdnIpaDomainConfigsResponseBodyDomainConfigs DomainConfigs { get; set; }
        public class DescribeDcdnIpaDomainConfigsResponseBodyDomainConfigs : TeaModel {
            [NameInMap("DomainConfig")]
            [Validation(Required=false)]
            public List<DescribeDcdnIpaDomainConfigsResponseBodyDomainConfigsDomainConfig> DomainConfig { get; set; }
            public class DescribeDcdnIpaDomainConfigsResponseBodyDomainConfigsDomainConfig : TeaModel {
                public string Status { get; set; }
                public string ConfigId { get; set; }
                public string FunctionName { get; set; }
                public DescribeDcdnIpaDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs FunctionArgs { get; set; }
                public class DescribeDcdnIpaDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs : TeaModel {
                    [NameInMap("FunctionArg")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnIpaDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg> FunctionArg { get; set; }
                    public class DescribeDcdnIpaDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg : TeaModel {
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
