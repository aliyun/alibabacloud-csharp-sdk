// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class UpdateTensorboardRequest : TeaModel {
        /// <summary>
        /// MaxRunningTimeMinutes
        /// </summary>
        [NameInMap("MaxRunningTimeMinutes")]
        [Validation(Required=false)]
        public long? MaxRunningTimeMinutes { get; set; }

        /// <summary>
        /// 工作空间ID
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
