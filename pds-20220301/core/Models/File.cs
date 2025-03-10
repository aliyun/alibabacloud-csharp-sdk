// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class File : TeaModel {
        [NameInMap("action_list")]
        [Validation(Required=false)]
        public List<string> ActionList { get; set; }

        [NameInMap("auto_delete_left_sec")]
        [Validation(Required=false)]
        public long? AutoDeleteLeftSec { get; set; }

        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("content_hash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        [NameInMap("content_hash_name")]
        [Validation(Required=false)]
        public string ContentHashName { get; set; }

        [NameInMap("content_type")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("crc64_hash")]
        [Validation(Required=false)]
        public string Crc64Hash { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("dir_size_info")]
        [Validation(Required=false)]
        public FileDirSizeInfo DirSizeInfo { get; set; }
        public class FileDirSizeInfo : TeaModel {
            [NameInMap("dir_count")]
            [Validation(Required=false)]
            public long? DirCount { get; set; }

            [NameInMap("file_count")]
            [Validation(Required=false)]
            public long? FileCount { get; set; }

        }

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

        [NameInMap("hidden")]
        [Validation(Required=false)]
        public bool? Hidden { get; set; }

        [NameInMap("id_path")]
        [Validation(Required=false)]
        public string IdPath { get; set; }

        [NameInMap("image_media_metadata")]
        [Validation(Required=false)]
        public ImageMediaMetadata ImageMediaMetadata { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

        [NameInMap("local_created_at")]
        [Validation(Required=false)]
        public string LocalCreatedAt { get; set; }

        [NameInMap("local_modified_at")]
        [Validation(Required=false)]
        public string LocalModifiedAt { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("name_path")]
        [Validation(Required=false)]
        public string NamePath { get; set; }

        [NameInMap("parent_file_id")]
        [Validation(Required=false)]
        public string ParentFileId { get; set; }

        [NameInMap("revision_id")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("starred")]
        [Validation(Required=false)]
        public bool? Starred { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("thumbnail")]
        [Validation(Required=false)]
        public string Thumbnail { get; set; }

        [NameInMap("thumbnail_urls")]
        [Validation(Required=false)]
        public Dictionary<string, string> ThumbnailUrls { get; set; }

        [NameInMap("trashed_at")]
        [Validation(Required=false)]
        public string TrashedAt { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

        [NameInMap("user_tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> UserTags { get; set; }

        [NameInMap("video_media_metadata")]
        [Validation(Required=false)]
        public VideoMediaMetadata VideoMediaMetadata { get; set; }

    }

}
