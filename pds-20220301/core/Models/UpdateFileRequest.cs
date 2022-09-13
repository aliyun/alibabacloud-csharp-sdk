// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateFileRequest : TeaModel {
        [NameInMap("check_name_mode")]
        [Validation(Required=false)]
        public string CheckNameMode { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("hidden")]
        [Validation(Required=false)]
        public bool? Hidden { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

        [NameInMap("local_modified_at")]
        [Validation(Required=false)]
        public string LocalModifiedAt { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("starred")]
        [Validation(Required=false)]
        public bool? Starred { get; set; }

    }

}
