// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryCloudRecordVideoPlayInfoShrinkRequest : TeaModel {
        [NameInMap("ConferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

    }

}
