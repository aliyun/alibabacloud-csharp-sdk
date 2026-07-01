// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class CreateDeploymentTargetV2Request : TeaModel {
        /// <summary>
        /// <para>The resources for the deployment target.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Resource Body { get; set; }

        /// <summary>
        /// <para>The name of the deployment target.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dt</para>
        /// </summary>
        [NameInMap("deploymentTargetName")]
        [Validation(Required=false)]
        public string DeploymentTargetName { get; set; }

    }

}
