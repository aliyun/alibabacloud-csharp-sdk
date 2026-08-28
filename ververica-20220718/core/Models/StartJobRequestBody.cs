// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StartJobRequestBody : TeaModel {
        /// <summary>
        /// <para>The ID of the deployed job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5a19a71b-1c42-4f34-94fd-86cf6078****</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// <para>The job resource settings.</para>
        /// </summary>
        [NameInMap("resourceSettingSpec")]
        [Validation(Required=false)]
        public BriefResourceSetting ResourceSettingSpec { get; set; }

        /// <summary>
        /// <para>The startup position settings for the job instance.</para>
        /// </summary>
        [NameInMap("restoreStrategy")]
        [Validation(Required=false)]
        public DeploymentRestoreStrategy RestoreStrategy { get; set; }

    }

}
