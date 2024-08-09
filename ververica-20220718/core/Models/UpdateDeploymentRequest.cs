// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UpdateDeploymentRequest : TeaModel {
        /// <summary>
        /// The information about the deployment that you want to update.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Deployment Body { get; set; }

    }

}
