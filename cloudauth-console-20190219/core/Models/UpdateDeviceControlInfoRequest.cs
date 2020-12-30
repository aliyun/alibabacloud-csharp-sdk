// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_console20190219.Models
{
    public class UpdateDeviceControlInfoRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("IotId")]
        [Validation(Required=false)]
        public long? IotId { get; set; }

        [NameInMap("MultiPerson")]
        [Validation(Required=false)]
        public int? MultiPerson { get; set; }

        [NameInMap("ControlDoorTime")]
        [Validation(Required=false)]
        public int? ControlDoorTime { get; set; }

        [NameInMap("EnableMeasureTempurature")]
        [Validation(Required=false)]
        public int? EnableMeasureTempurature { get; set; }

        [NameInMap("SpeedClock")]
        [Validation(Required=false)]
        public int? SpeedClock { get; set; }

    }

}
