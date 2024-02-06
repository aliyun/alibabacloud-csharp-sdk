// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AttachEnsInstancesRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can specify only one instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The command that you want to execute on the instance. The command must be encoded in Base64 or UTF-8.
        /// </summary>
        [NameInMap("Scripts")]
        [Validation(Required=false)]
        public string Scripts { get; set; }

    }

}
