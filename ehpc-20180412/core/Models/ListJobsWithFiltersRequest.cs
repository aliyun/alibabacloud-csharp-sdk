// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListJobsWithFiltersRequest : TeaModel {
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        [NameInMap("ExecuteOrder")]
        [Validation(Required=false)]
        public string ExecuteOrder { get; set; }

        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PendOrder")]
        [Validation(Required=false)]
        public string PendOrder { get; set; }

        [NameInMap("Queues")]
        [Validation(Required=false)]
        public List<string> Queues { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SubmitOrder")]
        [Validation(Required=false)]
        public string SubmitOrder { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

    }

}
