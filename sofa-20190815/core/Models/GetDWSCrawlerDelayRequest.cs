// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDWSCrawlerDelayRequest : TeaModel {
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("CrawlerName")]
        [Validation(Required=false)]
        public string CrawlerName { get; set; }

        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

    }

}
