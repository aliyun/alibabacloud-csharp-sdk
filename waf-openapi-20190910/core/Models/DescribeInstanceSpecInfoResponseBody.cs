// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeInstanceSpecInfoResponseBody : TeaModel {
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceSpecInfos")]
        [Validation(Required=false)]
        public List<DescribeInstanceSpecInfoResponseBodyInstanceSpecInfos> InstanceSpecInfos { get; set; }
        public class DescribeInstanceSpecInfoResponseBodyInstanceSpecInfos : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
