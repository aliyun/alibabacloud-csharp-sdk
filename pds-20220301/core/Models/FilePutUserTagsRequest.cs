// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FilePutUserTagsRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("user_tags")]
        [Validation(Required=false)]
        public List<FilePutUserTagsRequestUserTags> UserTags { get; set; }
        public class FilePutUserTagsRequestUserTags : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
