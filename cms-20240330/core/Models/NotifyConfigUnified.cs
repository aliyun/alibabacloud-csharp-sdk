// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyConfigUnified : TeaModel {
        [NameInMap("activeDays")]
        [Validation(Required=false)]
        public List<int?> ActiveDays { get; set; }

        [NameInMap("activeEndTime")]
        [Validation(Required=false)]
        public string ActiveEndTime { get; set; }

        [NameInMap("activeStartTime")]
        [Validation(Required=false)]
        public string ActiveStartTime { get; set; }

        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<DirectNotifyChannel> Channels { get; set; }

        [NameInMap("notifyStrategies")]
        [Validation(Required=false)]
        public List<string> NotifyStrategies { get; set; }

        [NameInMap("sendRecoverNotification")]
        [Validation(Required=false)]
        public bool? SendRecoverNotification { get; set; }

        [NameInMap("severityChannels")]
        [Validation(Required=false)]
        public Dictionary<string, SeverityNotifyConfig> SeverityChannels { get; set; }

        [NameInMap("silenceTimeSecs")]
        [Validation(Required=false)]
        public int? SilenceTimeSecs { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("utcOffset")]
        [Validation(Required=false)]
        public string UtcOffset { get; set; }

    }

}
