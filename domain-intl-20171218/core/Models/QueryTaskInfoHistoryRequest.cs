// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class QueryTaskInfoHistoryRequest : TeaModel {
        [NameInMap("BeginCreateTime")]
        [Validation(Required=false)]
        public long? BeginCreateTime { get; set; }

        [NameInMap("CreateTimeCursor")]
        [Validation(Required=false)]
        public long? CreateTimeCursor { get; set; }

        [NameInMap("EndCreateTime")]
        [Validation(Required=false)]
        public long? EndCreateTime { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TaskNoCursor")]
        [Validation(Required=false)]
        public string TaskNoCursor { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
