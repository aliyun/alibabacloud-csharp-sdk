// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ScheduledPlanAppliedInfo : TeaModel {
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        [NameInMap("expectedState")]
        [Validation(Required=false)]
        public string ExpectedState { get; set; }

        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public string ModifiedAt { get; set; }

        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        [NameInMap("modifierName")]
        [Validation(Required=false)]
        public string ModifierName { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("scheduledPlanId")]
        [Validation(Required=false)]
        public string ScheduledPlanId { get; set; }

        [NameInMap("scheduledPlanName")]
        [Validation(Required=false)]
        public string ScheduledPlanName { get; set; }

        [NameInMap("statusState")]
        [Validation(Required=false)]
        public string StatusState { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
