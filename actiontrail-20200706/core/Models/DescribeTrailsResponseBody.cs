// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeTrailsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// A list of returned trails.
        /// </summary>
        [NameInMap("TrailList")]
        [Validation(Required=false)]
        public List<DescribeTrailsResponseBodyTrailList> TrailList { get; set; }
        public class DescribeTrailsResponseBodyTrailList : TeaModel {
            /// <summary>
            /// The time when the trail was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The read/write type of the events that are delivered. Valid values:
            /// 
            /// *   Write: write events. This is the default value.
            /// *   Read: read events.
            /// *   All: read and write events.
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
            /// Indicates whether the trail is a multi-account trail. Valid values:
            /// 
            /// *   false (default)
            /// *   true
            /// </summary>
            [NameInMap("IsOrganizationTrail")]
            [Validation(Required=false)]
            public bool? IsOrganizationTrail { get; set; }

            /// <summary>
            /// The name of the trail.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the resource directory.
            /// 
            /// >  This parameter is returned only when the trail is a multi-account trail.
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// The region where the OSS bucket resides.
            /// </summary>
            [NameInMap("OssBucketLocation")]
            [Validation(Required=false)]
            public string OssBucketLocation { get; set; }

            /// <summary>
            /// The name of the OSS bucket to which events are delivered.
            /// </summary>
            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            /// <summary>
            /// The prefix of the files that are stored in the Object Storage Service (OSS) bucket.
            /// </summary>
            [NameInMap("OssKeyPrefix")]
            [Validation(Required=false)]
            public string OssKeyPrefix { get; set; }

            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the RAM role that is assumed by ActionTrail to deliver events to the OSS bucket.
            /// </summary>
            [NameInMap("OssWriteRoleArn")]
            [Validation(Required=false)]
            public string OssWriteRoleArn { get; set; }

            /// <summary>
            /// The region where the trail resides.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The ARN of the Log Service project to which events are delivered.
            /// </summary>
            [NameInMap("SlsProjectArn")]
            [Validation(Required=false)]
            public string SlsProjectArn { get; set; }

            /// <summary>
            /// The ARN of the RAM role that is assumed by ActionTrail to deliver events to the Log Service project.
            /// </summary>
            [NameInMap("SlsWriteRoleArn")]
            [Validation(Required=false)]
            public string SlsWriteRoleArn { get; set; }

            /// <summary>
            /// The time when the trail was last enabled.
            /// </summary>
            [NameInMap("StartLoggingTime")]
            [Validation(Required=false)]
            public string StartLoggingTime { get; set; }

            /// <summary>
            /// The status of the trail. Valid values:
            /// 
            /// *   Disable: disabled.
            /// *   Enable: enabled.
            /// *   Fresh: The trail is created but is not enabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the trail was last disabled.
            /// </summary>
            [NameInMap("StopLoggingTime")]
            [Validation(Required=false)]
            public string StopLoggingTime { get; set; }

            /// <summary>
            /// The ARN of the trail.
            /// </summary>
            [NameInMap("TrailArn")]
            [Validation(Required=false)]
            public string TrailArn { get; set; }

            /// <summary>
            /// The region of the trail.
            /// </summary>
            [NameInMap("TrailRegion")]
            [Validation(Required=false)]
            public string TrailRegion { get; set; }

            /// <summary>
            /// The time when the configurations of the trail were last updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
