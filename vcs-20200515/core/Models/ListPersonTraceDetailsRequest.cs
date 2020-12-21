// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListPersonTraceDetailsRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long PageSize { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PersonId")]
        [Validation(Required=false)]
        public string PersonId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("SubId")]
        [Validation(Required=false)]
        public string SubId { get; set; }

        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

    }

}
