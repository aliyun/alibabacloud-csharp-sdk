// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RenewInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The renewal duration of the subscription instance.
        /// 
        /// Valid values:
        /// 
        /// *   1
        /// *   2
        /// *   3
        /// *   4
        /// *   5
        /// *   6
        /// *   7
        /// *   8
        /// *   9
        /// *   12
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

    }

}
