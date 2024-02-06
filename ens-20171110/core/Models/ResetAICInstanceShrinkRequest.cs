// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ResetAICInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the AIC instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The IDs of the AIC instance groups.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <summary>
        /// The ID of the server.
        /// </summary>
        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

    }

}
