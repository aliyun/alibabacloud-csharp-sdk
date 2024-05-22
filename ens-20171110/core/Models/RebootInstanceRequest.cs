// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RebootInstanceRequest : TeaModel {
        /// <summary>
        /// Indicates whether to stop the instance forcibly before you reboot it. Default value: false. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public string ForceStop { get; set; }

        /// <summary>
        /// The ID of the instance that you want to reboot. You can specify only one instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
