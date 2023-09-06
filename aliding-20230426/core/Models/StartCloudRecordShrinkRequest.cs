// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class StartCloudRecordShrinkRequest : TeaModel {
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("SmallWindowPosition")]
        [Validation(Required=false)]
        public string SmallWindowPosition { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

    }

}
