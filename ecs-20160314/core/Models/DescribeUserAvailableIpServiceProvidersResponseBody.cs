// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeUserAvailableIpServiceProvidersResponseBody : TeaModel {
        [NameInMap("IpServiceProviders")]
        [Validation(Required=false)]
        public DescribeUserAvailableIpServiceProvidersResponseBodyIpServiceProviders IpServiceProviders { get; set; }
        public class DescribeUserAvailableIpServiceProvidersResponseBodyIpServiceProviders : TeaModel {
            [NameInMap("IpServiceProvider")]
            [Validation(Required=false)]
            public List<DescribeUserAvailableIpServiceProvidersResponseBodyIpServiceProvidersIpServiceProvider> IpServiceProvider { get; set; }
            public class DescribeUserAvailableIpServiceProvidersResponseBodyIpServiceProvidersIpServiceProvider : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
