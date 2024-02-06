// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ScheduledSQL : TeaModel {
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public ScheduledSQLConfiguration Configuration { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public long? LastModifiedTime { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("schedule")]
        [Validation(Required=false)]
        public Schedule Schedule { get; set; }

        [NameInMap("scheduleId")]
        [Validation(Required=false)]
        public string ScheduleId { get; set; }

    }

}
