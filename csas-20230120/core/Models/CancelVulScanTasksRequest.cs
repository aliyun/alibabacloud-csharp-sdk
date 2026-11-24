// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CancelVulScanTasksRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the vulnerability scanning nodes to cancel. You can specify 1 to 100 unique node IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<string> TaskIds { get; set; }

    }

}
