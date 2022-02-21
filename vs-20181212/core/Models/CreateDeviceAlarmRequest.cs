// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateDeviceAlarmRequest : TeaModel {
        [NameInMap("Alarm")]
        [Validation(Required=false)]
        public int? Alarm { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public int? ChannelId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public int? ObjectType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("SubAlarm")]
        [Validation(Required=false)]
        public int? SubAlarm { get; set; }

    }

}
