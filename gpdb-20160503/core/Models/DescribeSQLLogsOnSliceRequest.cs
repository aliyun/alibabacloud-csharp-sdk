// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSQLLogsOnSliceRequest : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("ExecuteState")]
        [Validation(Required=false)]
        public string ExecuteState { get; set; }

        [NameInMap("MaxExecuteCost")]
        [Validation(Required=false)]
        public string MaxExecuteCost { get; set; }

        [NameInMap("MinExecuteCost")]
        [Validation(Required=false)]
        public string MinExecuteCost { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        [NameInMap("SliceId")]
        [Validation(Required=false)]
        public string SliceId { get; set; }

    }

}
