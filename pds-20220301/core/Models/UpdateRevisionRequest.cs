// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateRevisionRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("keep_forever")]
        [Validation(Required=false)]
        public bool? KeepForever { get; set; }

        [NameInMap("revision_description")]
        [Validation(Required=false)]
        public string RevisionDescription { get; set; }

        [NameInMap("revision_id")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

    }

}
