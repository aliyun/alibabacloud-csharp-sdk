// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class ListJobRequest : TeaModel {
        [NameInMap("EndOfJobCreatedTimeRange")]
        [Validation(Required=false)]
        public string EndOfJobCreatedTimeRange { get; set; }

        [NameInMap("MaximumPageSize")]
        [Validation(Required=false)]
        public long? MaximumPageSize { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("StartOfJobCreatedTimeRange")]
        [Validation(Required=false)]
        public string StartOfJobCreatedTimeRange { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
