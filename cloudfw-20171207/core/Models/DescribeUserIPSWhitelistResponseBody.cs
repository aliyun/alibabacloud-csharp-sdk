// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserIPSWhitelistResponseBody : TeaModel {
        [NameInMap("Ipv6Whitelists")]
        [Validation(Required=false)]
        public List<DescribeUserIPSWhitelistResponseBodyIpv6Whitelists> Ipv6Whitelists { get; set; }
        public class DescribeUserIPSWhitelistResponseBodyIpv6Whitelists : TeaModel {
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public long? Direction { get; set; }

            [NameInMap("ListType")]
            [Validation(Required=false)]
            public long? ListType { get; set; }

            [NameInMap("ListValue")]
            [Validation(Required=false)]
            public string ListValue { get; set; }

            [NameInMap("WhiteListValue")]
            [Validation(Required=false)]
            public List<string> WhiteListValue { get; set; }

            [NameInMap("WhiteType")]
            [Validation(Required=false)]
            public long? WhiteType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Whitelists")]
        [Validation(Required=false)]
        public List<DescribeUserIPSWhitelistResponseBodyWhitelists> Whitelists { get; set; }
        public class DescribeUserIPSWhitelistResponseBodyWhitelists : TeaModel {
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public long? Direction { get; set; }

            [NameInMap("ListType")]
            [Validation(Required=false)]
            public long? ListType { get; set; }

            [NameInMap("ListValue")]
            [Validation(Required=false)]
            public string ListValue { get; set; }

            [NameInMap("WhiteListValue")]
            [Validation(Required=false)]
            public List<string> WhiteListValue { get; set; }

            [NameInMap("WhiteType")]
            [Validation(Required=false)]
            public long? WhiteType { get; set; }

        }

    }

}
