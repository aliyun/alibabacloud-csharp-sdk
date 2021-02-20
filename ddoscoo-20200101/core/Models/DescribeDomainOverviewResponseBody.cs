// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainOverviewResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MaxHttps")]
        [Validation(Required=false)]
        public long? MaxHttps { get; set; }

        [NameInMap("MaxHttp")]
        [Validation(Required=false)]
        public long? MaxHttp { get; set; }

    }

}
