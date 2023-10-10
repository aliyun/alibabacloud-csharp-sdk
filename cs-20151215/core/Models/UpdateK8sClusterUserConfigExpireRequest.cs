// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateK8sClusterUserConfigExpireRequest : TeaModel {
        /// <summary>
        /// The validity period of the kubeconfig file. Unit: hours.
        /// 
        /// > The value of expire_hour must be greater than 0 and equal to or smaller than 876000 (100 years).
        /// </summary>
        [NameInMap("expire_hour")]
        [Validation(Required=false)]
        public long? ExpireHour { get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        [NameInMap("user")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
