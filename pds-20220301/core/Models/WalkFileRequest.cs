// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class WalkFileRequest : TeaModel {
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("order_direction")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("parent_file_id")]
        [Validation(Required=false)]
        public string ParentFileId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
