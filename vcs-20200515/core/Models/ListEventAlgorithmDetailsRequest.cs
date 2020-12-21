// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListEventAlgorithmDetailsRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

        [NameInMap("EventValue")]
        [Validation(Required=false)]
        public string EventValue { get; set; }

        [NameInMap("ExtendValue")]
        [Validation(Required=false)]
        public string ExtendValue { get; set; }

    }

}
