// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20171204.Models
{
    public class DescribeTrailsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrailList")]
        [Validation(Required=false)]
        public List<DescribeTrailsResponseBodyTrailList> TrailList { get; set; }
        public class DescribeTrailsResponseBodyTrailList : TeaModel {
            [NameInMap("TrailRegion")]
            [Validation(Required=false)]
            public string TrailRegion { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("HomeRegion")]
            [Validation(Required=false)]
            public string HomeRegion { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("OssKeyPrefix")]
            [Validation(Required=false)]
            public string OssKeyPrefix { get; set; }

            [NameInMap("EventRW")]
            [Validation(Required=false)]
            public string EventRW { get; set; }

            [NameInMap("StartLoggingTime")]
            [Validation(Required=false)]
            public string StartLoggingTime { get; set; }

            [NameInMap("MnsTopicArn")]
            [Validation(Required=false)]
            public string MnsTopicArn { get; set; }

            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("SlsProjectArn")]
            [Validation(Required=false)]
            public string SlsProjectArn { get; set; }

            [NameInMap("IsOrganizationTrail")]
            [Validation(Required=false)]
            public bool? IsOrganizationTrail { get; set; }

            [NameInMap("SlsWriteRoleArn")]
            [Validation(Required=false)]
            public string SlsWriteRoleArn { get; set; }

            [NameInMap("StopLoggingTime")]
            [Validation(Required=false)]
            public string StopLoggingTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

        }

    }

}
