// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateCloudMigrationPrecheckTaskRequest : TeaModel {
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SourceAccount")]
        [Validation(Required=false)]
        public string SourceAccount { get; set; }

        [NameInMap("SourceCategory")]
        [Validation(Required=false)]
        public string SourceCategory { get; set; }

        [NameInMap("SourceIpAddress")]
        [Validation(Required=false)]
        public string SourceIpAddress { get; set; }

        [NameInMap("SourcePassword")]
        [Validation(Required=false)]
        public string SourcePassword { get; set; }

        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public long? SourcePort { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
