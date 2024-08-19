// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyPolicyGroupRequest : TeaModel {
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
        public ModifyPolicyGroupRequestNetRedirectPolicy NetRedirectPolicy { get; set; }
        public class ModifyPolicyGroupRequestNetRedirectPolicy : TeaModel {
            [NameInMap("NetRedirect")]
            [Validation(Required=false)]
            public string NetRedirect { get; set; }

            [NameInMap("NetRedirectRule")]
            [Validation(Required=false)]
            public List<ModifyPolicyGroupRequestNetRedirectPolicyNetRedirectRule> NetRedirectRule { get; set; }
            public class ModifyPolicyGroupRequestNetRedirectPolicyNetRedirectRule : TeaModel {
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

            }

        }

        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

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
