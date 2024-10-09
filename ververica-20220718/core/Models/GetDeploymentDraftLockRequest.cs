// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetDeploymentDraftLockRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c84d73be-40ad-4627-8bdd-fa1eba51b234</para>
        /// </summary>
        [NameInMap("deploymentDraftId")]
        [Validation(Required=false)]
        public string DeploymentDraftId { get; set; }

    }

}
