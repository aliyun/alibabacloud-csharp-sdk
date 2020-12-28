// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20171204.Models
{
    public class UpdateTrailRequest : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        [NameInMap("OssKeyPrefix")]
        [Validation(Required=false)]
        public string OssKeyPrefix { get; set; }

        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        [NameInMap("SlsProjectArn")]
        [Validation(Required=false)]
        public string SlsProjectArn { get; set; }

        [NameInMap("SlsWriteRoleArn")]
        [Validation(Required=false)]
        public string SlsWriteRoleArn { get; set; }

        [NameInMap("EventRW")]
        [Validation(Required=false)]
        public string EventRW { get; set; }

        [NameInMap("TrailRegion")]
        [Validation(Required=false)]
        public string TrailRegion { get; set; }

        [NameInMap("MnsTopicArn")]
        [Validation(Required=false)]
        public string MnsTopicArn { get; set; }

    }

}
