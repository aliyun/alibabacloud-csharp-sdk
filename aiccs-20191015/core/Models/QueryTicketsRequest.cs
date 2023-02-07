// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTicketsRequest : TeaModel {
        [NameInMap("CaseId")]
        [Validation(Required=false)]
        public long? CaseId { get; set; }

        [NameInMap("CaseStatus")]
        [Validation(Required=false)]
        public int? CaseStatus { get; set; }

        [NameInMap("CaseType")]
        [Validation(Required=false)]
        public int? CaseType { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public int? ChannelType { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("DealId")]
        [Validation(Required=false)]
        public long? DealId { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extra { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SrType")]
        [Validation(Required=false)]
        public long? SrType { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public int? TaskStatus { get; set; }

        [NameInMap("TouchId")]
        [Validation(Required=false)]
        public long? TouchId { get; set; }

    }

}
