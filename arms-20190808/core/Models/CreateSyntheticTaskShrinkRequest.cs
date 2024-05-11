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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IntervalTime")]
        [Validation(Required=false)]
        public string IntervalTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IntervalType")]
        [Validation(Required=false)]
        public string IntervalType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public long? IpType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public long? TaskType { get; set; }

        [NameInMap("UpdateTask")]
        [Validation(Required=false)]
        public bool? UpdateTask { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
