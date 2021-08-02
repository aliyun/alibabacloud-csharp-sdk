// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20210728.Models
{
    public class QueryTraceAbRequest : TeaModel {
        /// <summary>
        /// 任务id
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// 媒体id
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

    }

}
