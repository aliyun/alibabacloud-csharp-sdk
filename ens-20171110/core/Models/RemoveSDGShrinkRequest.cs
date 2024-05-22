// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RemoveSDGShrinkRequest : TeaModel {
        /// <summary>
        /// IDs of Android in Container (AIC) instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

    }

}
