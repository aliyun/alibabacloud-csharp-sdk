// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListApmApplicationRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DiagnoseResult")]
        [Validation(Required=false)]
        public string DiagnoseResult { get; set; }

        [NameInMap("EndTimeFrom")]
        [Validation(Required=false)]
        public long? EndTimeFrom { get; set; }

        [NameInMap("EndTimeTo")]
        [Validation(Required=false)]
        public long? EndTimeTo { get; set; }

        [NameInMap("FinalStatus")]
        [Validation(Required=false)]
        public string FinalStatus { get; set; }

        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Queue")]
        [Validation(Required=false)]
        public string Queue { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("StartTimeFrom")]
        [Validation(Required=false)]
        public long? StartTimeFrom { get; set; }

        [NameInMap("StartTimeTo")]
        [Validation(Required=false)]
        public long? StartTimeTo { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
