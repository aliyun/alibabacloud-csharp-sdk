// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateOrUpdateSwimmingLaneGroupRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

        [NameInMap("DbGrayEnable")]
        [Validation(Required=false)]
        public bool? DbGrayEnable { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("EntryApp")]
        [Validation(Required=false)]
        public string EntryApp { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("LicenseKey")]
        [Validation(Required=false)]
        public string LicenseKey { get; set; }

        [NameInMap("MessageQueueFilterSide")]
        [Validation(Required=false)]
        public string MessageQueueFilterSide { get; set; }

        [NameInMap("MessageQueueGrayEnable")]
        [Validation(Required=false)]
        public bool? MessageQueueGrayEnable { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
