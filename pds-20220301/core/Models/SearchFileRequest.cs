// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchFileRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("return_total_count")]
        [Validation(Required=false)]
        public bool? ReturnTotalCount { get; set; }

    }

}
