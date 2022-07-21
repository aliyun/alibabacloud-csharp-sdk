// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class StopJobsRequest : TeaModel {
        /// <summary>
        /// 作业ID列表
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public List<string> JobIds { get; set; }

    }

}
