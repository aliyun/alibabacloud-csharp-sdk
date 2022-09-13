// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ScanFileRequest : TeaModel {
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

    }

}
