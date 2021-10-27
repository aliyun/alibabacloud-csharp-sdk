// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeTrailsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrailList")]
        [Validation(Required=false)]
        public List<DescribeTrailsResponseBodyTrailList> TrailList { get; set; }
        public class DescribeTrailsResponseBodyTrailList : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EventRW")]
            [Validation(Required=false)]
            public string EventRW { get; set; }

            [NameInMap("HomeRegion")]
            [Validation(Required=false)]
            public string HomeRegion { get; set; }

            [NameInMap("IsOrganizationTrail")]
            [Validation(Required=false)]
            public bool? IsOrganizationTrail { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("OssBucketLocation")]
            [Validation(Required=false)]
            public string OssBucketLocation { get; set; }

            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            [NameInMap("OssKeyPrefix")]
            [Validation(Required=false)]
            public string OssKeyPrefix { get; set; }

            [NameInMap("OssWriteRoleArn")]
            [Validation(Required=false)]
            public string OssWriteRoleArn { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("SlsProjectArn")]
            [Validation(Required=false)]
            public string SlsProjectArn { get; set; }

            [NameInMap("SlsWriteRoleArn")]
            [Validation(Required=false)]
            public string SlsWriteRoleArn { get; set; }

            [NameInMap("StartLoggingTime")]
            [Validation(Required=false)]
            public string StartLoggingTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StopLoggingTime")]
            [Validation(Required=false)]
            public string StopLoggingTime { get; set; }

            [NameInMap("TrailArn")]
            [Validation(Required=false)]
            public string TrailArn { get; set; }

            [NameInMap("TrailRegion")]
            [Validation(Required=false)]
            public string TrailRegion { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
