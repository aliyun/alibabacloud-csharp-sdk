// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StartJobRequestBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5a19a71b-1c42-4f34-94fd-86cf60782c81</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        [NameInMap("resourceSettingSpec")]
        [Validation(Required=false)]
        public BriefResourceSetting ResourceSettingSpec { get; set; }

        [NameInMap("restoreStrategy")]
        [Validation(Required=false)]
        public DeploymentRestoreStrategy RestoreStrategy { get; set; }

    }

}
