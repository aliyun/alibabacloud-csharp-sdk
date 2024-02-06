// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class StopInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to forcibly stop the servers.
        /// 
        /// *   **true**: forcibly stops the instance.
        /// *   **false**: normally stops the servers. This is the default value.
        /// </summary>
        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public string ForceStop { get; set; }

        /// <summary>
        /// The ID of the instance that you want to stop. You can specify only one instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
