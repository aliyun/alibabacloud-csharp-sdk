// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UpdateDeploymentDraftRequest : TeaModel {
        /// <summary>
        /// <para>The information to update the job draft.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public DeploymentDraft Body { get; set; }

    }

}
