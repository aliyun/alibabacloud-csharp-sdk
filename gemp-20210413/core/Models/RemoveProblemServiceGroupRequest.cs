// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class RemoveProblemServiceGroupRequest : TeaModel {
        /// <summary>
        /// 故障ID
        /// </summary>
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        /// <summary>
        /// 应急协同组
        /// </summary>
        [NameInMap("serviceGroupIds")]
        [Validation(Required=false)]
        public List<long?> ServiceGroupIds { get; set; }

    }

}
