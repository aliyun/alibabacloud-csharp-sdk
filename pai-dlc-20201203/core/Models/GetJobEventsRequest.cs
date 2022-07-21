// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobEventsRequest : TeaModel {
        /// <summary>
        /// 查询事件的时间区间的截止时间，默认值是当前。
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 获取事件的最大数目，默认值：2000
        /// </summary>
        [NameInMap("MaxEventsNum")]
        [Validation(Required=false)]
        public int? MaxEventsNum { get; set; }

        /// <summary>
        /// 查询事件的时间区间的起始时间，默认值是7天前。
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
