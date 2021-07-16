// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateProblemTimelinesRequest : TeaModel {
        /// <summary>
        /// 故障id
        /// </summary>
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        /// <summary>
        /// 时间线节点
        /// </summary>
        [NameInMap("timelineNodes")]
        [Validation(Required=false)]
        public string TimelineNodes { get; set; }

        /// <summary>
        /// clientToken
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
