// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class StrogeCollectTask : TeaModel {
        [NameInMap("DestinationBucketName")]
        [Validation(Required=false)]
        public string DestinationBucketName { get; set; }

        [NameInMap("DestinationPrefix")]
        [Validation(Required=false)]
        public string DestinationPrefix { get; set; }

        [NameInMap("DlfCreated")]
        [Validation(Required=false)]
        public bool? DlfCreated { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("InventoryId")]
        [Validation(Required=false)]
        public string InventoryId { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
