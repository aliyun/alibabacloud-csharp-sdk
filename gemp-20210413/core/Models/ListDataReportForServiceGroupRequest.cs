// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListDataReportForServiceGroupRequest : TeaModel {
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("serviceGroupName")]
        [Validation(Required=false)]
        public string ServiceGroupName { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
