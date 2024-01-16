// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateGrafanaWorkspaceShrinkRequest : TeaModel {
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GrafanaVersion")]
        [Validation(Required=false)]
        public string GrafanaVersion { get; set; }

        [NameInMap("GrafanaWorkspaceEdition")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceEdition { get; set; }

        [NameInMap("GrafanaWorkspaceName")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceName { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
