// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class CreateSavepointRequest : TeaModel {
        /// <summary>
        /// The deployment ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// The description of the savepoint.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to use the native format mode. Valid values:
        /// 
        /// *   true: The native format mode is used.
        /// *   false: The native format mode is not used.
        /// </summary>
        [NameInMap("nativeFormat")]
        [Validation(Required=false)]
        public bool? NativeFormat { get; set; }

    }

}
