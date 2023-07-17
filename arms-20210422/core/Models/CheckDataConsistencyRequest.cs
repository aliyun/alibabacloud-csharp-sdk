// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
{
    public class CheckDataConsistencyRequest : TeaModel {
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("CurrentTimestamp")]
        [Validation(Required=false)]
        public long? CurrentTimestamp { get; set; }

        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        [NameInMap("ProxyUserId")]
        [Validation(Required=false)]
        public string ProxyUserId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
