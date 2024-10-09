// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DraftDeployParams : TeaModel {
        [NameInMap("deploymentDraftId")]
        [Validation(Required=false)]
        public string DeploymentDraftId { get; set; }

        [NameInMap("deploymentTarget")]
        [Validation(Required=false)]
        public BriefDeploymentTarget DeploymentTarget { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("skipValidate")]
        [Validation(Required=false)]
        public bool? SkipValidate { get; set; }

    }

}
