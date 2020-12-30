// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeAppDailySdkVersionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AppDailySdkVersions")]
        [Validation(Required=false)]
        public List<DescribeAppDailySdkVersionsResponseBodyAppDailySdkVersions> AppDailySdkVersions { get; set; }
        public class DescribeAppDailySdkVersionsResponseBodyAppDailySdkVersions : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

        }

    }

}
