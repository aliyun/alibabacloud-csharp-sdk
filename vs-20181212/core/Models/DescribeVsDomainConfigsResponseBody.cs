// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainConfigsResponseBody : TeaModel {
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public List<DescribeVsDomainConfigsResponseBodyDomainConfigs> DomainConfigs { get; set; }
        public class DescribeVsDomainConfigsResponseBodyDomainConfigs : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            [NameInMap("FunctionArgs")]
            [Validation(Required=false)]
            public List<DescribeVsDomainConfigsResponseBodyDomainConfigsFunctionArgs> FunctionArgs { get; set; }
            public class DescribeVsDomainConfigsResponseBodyDomainConfigsFunctionArgs : TeaModel {
                [NameInMap("ArgName")]
                [Validation(Required=false)]
                public string ArgName { get; set; }

                [NameInMap("ArgValue")]
                [Validation(Required=false)]
                public string ArgValue { get; set; }

            }

            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
