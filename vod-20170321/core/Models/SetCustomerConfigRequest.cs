// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetCustomerConfigRequest : TeaModel {
        [NameInMap("AIConfig")]
        [Validation(Required=false)]
        public string AIConfig { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AuditConfig")]
        [Validation(Required=false)]
        public string AuditConfig { get; set; }

        [NameInMap("DownloadSwitch")]
        [Validation(Required=false)]
        public string DownloadSwitch { get; set; }

        [NameInMap("MetricConfig")]
        [Validation(Required=false)]
        public string MetricConfig { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
