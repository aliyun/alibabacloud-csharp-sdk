// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Revision : TeaModel {
        [NameInMap("content_hash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        [NameInMap("content_hash_name")]
        [Validation(Required=false)]
        public string ContentHashName { get; set; }

        [NameInMap("crc64_hash")]
        [Validation(Required=false)]
        public string Crc64Hash { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("download_url")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("file_extension")]
        [Validation(Required=false)]
        public string FileExtension { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("is_latest_version")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        [NameInMap("keep_forever")]
        [Validation(Required=false)]
        public bool? KeepForever { get; set; }

        [NameInMap("revision_description")]
        [Validation(Required=false)]
        public string RevisionDescription { get; set; }

        [NameInMap("revision_id")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

        [NameInMap("revision_name")]
        [Validation(Required=false)]
        public string RevisionName { get; set; }

        [NameInMap("revision_version")]
        [Validation(Required=false)]
        public long? RevisionVersion { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("thumbnail")]
        [Validation(Required=false)]
        public string Thumbnail { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
