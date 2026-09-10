// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class DeleteDataCheckTaskRequest : TeaModel {
        /// <summary>
        /// <para>The list of task IDs. Batch deletion is supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("taskIds")]
        [Validation(Required=false)]
        public List<long?> TaskIds { get; set; }

    }

}
