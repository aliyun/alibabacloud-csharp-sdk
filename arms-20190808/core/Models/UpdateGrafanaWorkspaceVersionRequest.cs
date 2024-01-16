// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateGrafanaWorkspaceVersionRequest : TeaModel {
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        [NameInMap("GrafanaVersion")]
        [Validation(Required=false)]
        public string GrafanaVersion { get; set; }

        [NameInMap("GrafanaWorkspaceId")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
