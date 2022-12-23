// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodTranscodeDataRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The time granularity at which the data is queried. Valid values:
        /// 
        /// *   **day**
        /// *   **hour**
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region where the transcoded file is stored. If you do not set this parameter, the data in all regions is returned. You can specify multiple regions. Separate them with commas (,). Valid values:
        /// 
        /// *   **cn-shanghai**: China (Shanghai)
        /// *   **cn-beijing**: China (Beijing)
        /// *   **eu-central-1**: Germany (Frankfurt)
        /// *   **ap-southeast-1**: Singapore
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The transcoding specification. If you do not set this parameter, the data of all transcoding specifications is returned. You can specify multiple transcoding specifications. Separate them with commas (,). Valid values:
        /// 
        /// *   **Audio**: audio transcoding
        /// *   **Segmentation**: container format conversion
        /// *   H.264 and H.265-related video transcoding specifications, such as **H264.LD**, **H264.SD**, **H264.HD**, **H264.2K**, and **H264.4K**
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The name of the Object Storage Service (OSS) bucket. If you do not set this parameter, the data of all buckets is returned. You can specify multiple buckets. Separate them with commas (,).
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public string Storage { get; set; }

    }

}
