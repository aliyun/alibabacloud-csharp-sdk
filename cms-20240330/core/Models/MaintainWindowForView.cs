// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MaintainWindowForView : TeaModel {
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("effectTimeRange")]
        [Validation(Required=false)]
        public MaintainWindowForViewEffectTimeRange EffectTimeRange { get; set; }
        public class MaintainWindowForViewEffectTimeRange : TeaModel {
            [NameInMap("dayInWeek")]
            [Validation(Required=false)]
            public List<int?> DayInWeek { get; set; }

            [NameInMap("endTimeInMinute")]
            [Validation(Required=false)]
            public int? EndTimeInMinute { get; set; }

            [NameInMap("startTimeInMinute")]
            [Validation(Required=false)]
            public int? StartTimeInMinute { get; set; }

            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        [NameInMap("effective")]
        [Validation(Required=false)]
        public string Effective { get; set; }

        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        [NameInMap("maintainWindowId")]
        [Validation(Required=false)]
        public string MaintainWindowId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("maintainWindowName")]
        [Validation(Required=false)]
        public string MaintainWindowName { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
