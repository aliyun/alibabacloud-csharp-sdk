// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class CreateTrailRequest : TeaModel {
        [NameInMap("EventRW")]
        [Validation(Required=false)]
        public string EventRW { get; set; }

        [NameInMap("IsOrganizationTrail")]
        [Validation(Required=false)]
        public bool? IsOrganizationTrail { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        [NameInMap("OssKeyPrefix")]
        [Validation(Required=false)]
        public string OssKeyPrefix { get; set; }

        [NameInMap("OssWriteRoleArn")]
        [Validation(Required=false)]
        public string OssWriteRoleArn { get; set; }

        [NameInMap("SlsProjectArn")]
        [Validation(Required=false)]
        public string SlsProjectArn { get; set; }

        [NameInMap("SlsWriteRoleArn")]
        [Validation(Required=false)]
        public string SlsWriteRoleArn { get; set; }

        [NameInMap("TrailRegion")]
        [Validation(Required=false)]
        public string TrailRegion { get; set; }

    }

}
