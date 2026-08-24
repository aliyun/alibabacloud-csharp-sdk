// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CancelVulScanTasksRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the vulnerability scanning tasks to cancel. The collection must contain at least 1 and at most 100 IDs. Duplicate IDs are not allowed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<string> TaskIds { get; set; }

    }

}
