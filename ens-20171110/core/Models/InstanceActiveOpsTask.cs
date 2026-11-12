// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class InstanceActiveOpsTask : TeaModel {
        /// <summary>
        /// <para>instance active ops task id</para>
        /// </summary>
        [NameInMap("InstanceActiveOpsTaskId")]
        [Validation(Required=false)]
        public string InstanceActiveOpsTaskId { get; set; }

        /// <summary>
        /// <para>the status of instance active ops task</para>
        /// </summary>
        [NameInMap("InstanceActiveOpsTaskStatus")]
        [Validation(Required=false)]
        public string InstanceActiveOpsTaskStatus { get; set; }

    }

}
