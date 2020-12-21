// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListPersonVisitCountRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("AggregateType")]
        [Validation(Required=false)]
        public string AggregateType { get; set; }

        [NameInMap("TagCode")]
        [Validation(Required=false)]
        public string TagCode { get; set; }

        [NameInMap("TimeAggregateType")]
        [Validation(Required=false)]
        public string TimeAggregateType { get; set; }

        [NameInMap("MinVal")]
        [Validation(Required=false)]
        public int? MinVal { get; set; }

        [NameInMap("MaxVal")]
        [Validation(Required=false)]
        public int? MaxVal { get; set; }

        [NameInMap("CountType")]
        [Validation(Required=false)]
        public string CountType { get; set; }

    }

}
