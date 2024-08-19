// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreatePolicyGroupShrinkRequest : TeaModel {
        [NameInMap("CameraRedirect")]
        [Validation(Required=false)]
        public string CameraRedirect { get; set; }

        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public string Clipboard { get; set; }

        [NameInMap("Html5FileTransfer")]
        [Validation(Required=false)]
        public string Html5FileTransfer { get; set; }

        [NameInMap("LocalDrive")]
        [Validation(Required=false)]
        public string LocalDrive { get; set; }

        [NameInMap("NetRedirectPolicy")]
        [Validation(Required=false)]
        public string NetRedirectPolicyShrink { get; set; }

        [NameInMap("PolicyGroupName")]
        [Validation(Required=false)]
        public string PolicyGroupName { get; set; }

        [NameInMap("ResolutionHeight")]
        [Validation(Required=false)]
        public int? ResolutionHeight { get; set; }

        [NameInMap("ResolutionWidth")]
        [Validation(Required=false)]
        public int? ResolutionWidth { get; set; }

    }

}
