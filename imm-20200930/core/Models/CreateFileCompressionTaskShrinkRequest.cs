// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateFileCompressionTaskShrinkRequest : TeaModel {
        [NameInMap("CompressedFormat")]
        [Validation(Required=false)]
        public string CompressedFormat { get; set; }

        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("SourceManifestURI")]
        [Validation(Required=false)]
        public string SourceManifestURI { get; set; }

        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string SourcesShrink { get; set; }

        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
