// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyPortAutoCcStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// > You can call the [DescribeInstanceIds](~~157459~~) operation to query the IDs of all instances.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The mode of the Intelligent Protection policy. Valid values:
        /// 
        /// *   **normal**
        /// *   **loose**
        /// *   **strict**
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// Specifies the status of the Intelligent Protection policy. Valid values:
        /// 
        /// *   **on**: enables the policy.
        /// *   **off**: disables the policy.
        /// </summary>
        [NameInMap("Switch")]
        [Validation(Required=false)]
        public string Switch { get; set; }

    }

}
