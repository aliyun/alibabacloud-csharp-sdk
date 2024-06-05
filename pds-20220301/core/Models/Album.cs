// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Album : TeaModel {
        [NameInMap("album_id")]
        [Validation(Required=false)]
        public string AlbumId { get; set; }

        [NameInMap("base_face_file")]
        [Validation(Required=false)]
        public File BaseFaceFile { get; set; }

        [NameInMap("base_face_group_id")]
        [Validation(Required=false)]
        public string BaseFaceGroupId { get; set; }

        [NameInMap("cover_file")]
        [Validation(Required=false)]
        public File CoverFile { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("file_count")]
        [Validation(Required=false)]
        public long? FileCount { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("user_tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> UserTags { get; set; }

    }

}
