// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DraftDeployParams : TeaModel {
        /// <summary>
        /// <para>The draft ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c84d73be-40ad-4627-8bdd-fa1eba51****</para>
        /// </summary>
        [NameInMap("deploymentDraftId")]
        [Validation(Required=false)]
        public string DeploymentDraftId { get; set; }

        /// <summary>
        /// <para>The cluster on which the deployment is deployed.</para>
        /// </summary>
        [NameInMap("deploymentTarget")]
        [Validation(Required=false)]
        public BriefDeploymentTarget DeploymentTarget { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip the syntax check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("skipValidate")]
        [Validation(Required=false)]
        public bool? SkipValidate { get; set; }

    }

}
