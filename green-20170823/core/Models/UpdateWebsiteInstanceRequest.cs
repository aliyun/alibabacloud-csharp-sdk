// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class UpdateWebsiteInstanceRequest : TeaModel {
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("IndexPage")]
        [Validation(Required=false)]
        public string IndexPage { get; set; }

        [NameInMap("IndexPageScanInterval")]
        [Validation(Required=false)]
        public int? IndexPageScanInterval { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("SiteProtocol")]
        [Validation(Required=false)]
        public string SiteProtocol { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("WebsiteScanInterval")]
        [Validation(Required=false)]
        public int? WebsiteScanInterval { get; set; }

    }

}
