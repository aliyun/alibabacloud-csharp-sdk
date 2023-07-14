// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateSyntheticTaskShrinkRequest : TeaModel {
        [NameInMap("CommonParam")]
        [Validation(Required=false)]
        public string CommonParamShrink { get; set; }

        [NameInMap("Download")]
        [Validation(Required=false)]
        public string DownloadShrink { get; set; }

        [NameInMap("ExtendInterval")]
        [Validation(Required=false)]
        public string ExtendIntervalShrink { get; set; }

        [NameInMap("IntervalTime")]
        [Validation(Required=false)]
        public string IntervalTime { get; set; }

        [NameInMap("IntervalType")]
        [Validation(Required=false)]
        public string IntervalType { get; set; }

        [NameInMap("IpType")]
        [Validation(Required=false)]
        public long? IpType { get; set; }

        [NameInMap("MonitorList")]
        [Validation(Required=false)]
        public string MonitorListShrink { get; set; }

        [NameInMap("Navigation")]
        [Validation(Required=false)]
        public string NavigationShrink { get; set; }

        [NameInMap("Net")]
        [Validation(Required=false)]
        public string NetShrink { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string ProtocolShrink { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public long? TaskType { get; set; }

        [NameInMap("UpdateTask")]
        [Validation(Required=false)]
        public bool? UpdateTask { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
