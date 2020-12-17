// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class SetTemplatePermissionRequest : TeaModel {
        [NameInMap("ShareOption")]
        [Validation(Required=true)]
        public string ShareOption { get; set; }

        [NameInMap("VersionOption")]
        [Validation(Required=false)]
        public string VersionOption { get; set; }

        [NameInMap("AccountIds")]
        [Validation(Required=true)]
        public List<string> AccountIds { get; set; }

        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=true)]
        public string TemplateId { get; set; }

    }

}
