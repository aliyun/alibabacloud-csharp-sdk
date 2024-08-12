// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class GetDeviceUpgradeStatusRequest : TeaModel {
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("ClientUid")]
        [Validation(Required=false)]
        public string ClientUid { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("TaskUid")]
        [Validation(Required=false)]
        public string TaskUid { get; set; }

    }

}
