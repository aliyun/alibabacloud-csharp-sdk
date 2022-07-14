// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListMediaWorkflowExecutionsRequest : TeaModel {
        [NameInMap("InputFileURL")]
        [Validation(Required=false)]
        public string InputFileURL { get; set; }

        [NameInMap("MaximumPageSize")]
        [Validation(Required=false)]
        public long? MaximumPageSize { get; set; }

        [NameInMap("MediaWorkflowId")]
        [Validation(Required=false)]
        public string MediaWorkflowId { get; set; }

        [NameInMap("MediaWorkflowName")]
        [Validation(Required=false)]
        public string MediaWorkflowName { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
