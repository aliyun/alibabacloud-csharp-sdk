// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class UpdateTrailResponseBody : TeaModel {
        /// <summary>
        /// The read/write type of the events to be delivered.
        /// </summary>
        [NameInMap("EventRW")]
        [Validation(Required=false)]
        public string EventRW { get; set; }

        /// <summary>
        /// The home region of the trail.
        /// </summary>
        [NameInMap("HomeRegion")]
        [Validation(Required=false)]
        public string HomeRegion { get; set; }

        /// <summary>
        /// The name of the trail.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the OSS bucket.
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// The prefix of the log files to be stored in the destination OSS bucket.
        /// </summary>
        [NameInMap("OssKeyPrefix")]
        [Validation(Required=false)]
        public string OssKeyPrefix { get; set; }

        /// <summary>
        /// The ARN of the RAM role that is assumed by ActionTrail to deliver events to the OSS bucket.
        /// </summary>
        [NameInMap("OssWriteRoleArn")]
        [Validation(Required=false)]
        public string OssWriteRoleArn { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ARN of the Log Service project to which events are to be delivered.
        /// </summary>
        [NameInMap("SlsProjectArn")]
        [Validation(Required=false)]
        public string SlsProjectArn { get; set; }

        /// <summary>
        /// The ARN of the RAM role that is assumed by ActionTrail is to deliver events to the Log Service project.
        /// </summary>
        [NameInMap("SlsWriteRoleArn")]
        [Validation(Required=false)]
        public string SlsWriteRoleArn { get; set; }

        /// <summary>
        /// The one or more regions from which the trail delivers events.
        /// </summary>
        [NameInMap("TrailRegion")]
        [Validation(Required=false)]
        public string TrailRegion { get; set; }

    }

}
