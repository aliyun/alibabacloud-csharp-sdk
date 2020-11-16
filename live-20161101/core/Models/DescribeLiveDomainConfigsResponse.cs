// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainConfigsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DomainConfigs")]
        [Validation(Required=true)]
        public DescribeLiveDomainConfigsResponseDomainConfigs DomainConfigs { get; set; }
        public class DescribeLiveDomainConfigsResponseDomainConfigs : TeaModel {
            [NameInMap("DomainConfig")]
            [Validation(Required=true)]
            public List<DescribeLiveDomainConfigsResponseDomainConfigsDomainConfig> DomainConfig { get; set; }
            public class DescribeLiveDomainConfigsResponseDomainConfigsDomainConfig : TeaModel {
                public string FunctionName { get; set; }
                public string ConfigId { get; set; }
                public string Status { get; set; }
                public DescribeLiveDomainConfigsResponseDomainConfigsDomainConfigFunctionArgs FunctionArgs { get; set; }
                public class DescribeLiveDomainConfigsResponseDomainConfigsDomainConfigFunctionArgs : TeaModel {
                    [NameInMap("FunctionArg")]
                    [Validation(Required=true)]
                    public List<DescribeLiveDomainConfigsResponseDomainConfigsDomainConfigFunctionArgsFunctionArg> FunctionArg { get; set; }
                    public class DescribeLiveDomainConfigsResponseDomainConfigsDomainConfigFunctionArgsFunctionArg : TeaModel {
                        [NameInMap("ArgName")]
                        [Validation(Required=true)]
                        public string ArgName { get; set; }

                        [NameInMap("ArgValue")]
                        [Validation(Required=true)]
                        public string ArgValue { get; set; }

                    }

                }
            }
        };

    }

}
