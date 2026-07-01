// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UpdateDeploymentTargetRequest : TeaModel {
        /// <summary>
        /// <para>The resource specifications for the updated deployment target.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ResourceSpec Body { get; set; }

    }

}
