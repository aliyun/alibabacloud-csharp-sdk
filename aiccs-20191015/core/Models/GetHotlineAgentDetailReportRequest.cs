// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineAgentDetailReportRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("DepIds")]
        [Validation(Required=false)]
        public List<int?> DepIds { get; set; }

        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public List<int?> GroupIds { get; set; }

    }

}
