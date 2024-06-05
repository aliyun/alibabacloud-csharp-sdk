// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateFileRequest : TeaModel {
        /// <summary>
        /// The processing method that is used if the file that you want to create has the same name as an existing file in the cloud. Valid values:
        /// 
        /// ignore: allows you to create the file by using the same name as an existing file in the cloud.
        /// 
        /// auto_rename: automatically renames the file that you want to create. By default, the current point in time is added to the end of the file name. Example: xxx_20060102_150405.
        /// 
        /// refuse: does not create the file that you want to create but returns the information about the file that has the same name in the cloud.
        /// 
        /// Default value: ignore.
        /// </summary>
        [NameInMap("check_name_mode")]
        [Validation(Required=false)]
        public string CheckNameMode { get; set; }

        /// <summary>
        /// The hash value of the file content. The value is calculated based on the algorithm specified by content_hash_name.
        /// </summary>
        [NameInMap("content_hash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        /// <summary>
        /// The name of the algorithm that is used to calculate the hash value of the file content. Only SHA1 is supported.
        /// </summary>
        [NameInMap("content_hash_name")]
        [Validation(Required=false)]
        public string ContentHashName { get; set; }

        /// <summary>
        /// The type of the file content. Default value: application/oct-stream.
        /// </summary>
        [NameInMap("content_type")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// The description of the file. The description can be up to 1,024 characters in length. By default, this parameter is left empty.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The drive ID. This parameter is required if the file is not uploaded by using the share URL of the file.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// The file ID. This parameter is required if check_name_mode is set to ignore.
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Specifies whether to hide the file or folder. By default, the file or folder is not hidden.
        /// </summary>
        [NameInMap("hidden")]
        [Validation(Required=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// The information about the image specified by the client.
        /// </summary>
        [NameInMap("image_media_metadata")]
        [Validation(Required=false)]
        public ImageMediaMetadata ImageMediaMetadata { get; set; }

        /// <summary>
        /// The time when the local file was created. By default, this parameter is left empty. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format based on the UTC+0 time zone.
        /// </summary>
        [NameInMap("local_created_at")]
        [Validation(Required=false)]
        public string LocalCreatedAt { get; set; }

        /// <summary>
        /// The time when the local file was modified. By default, this parameter is left empty. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format based on the UTC+0 time zone.
        /// </summary>
        [NameInMap("local_modified_at")]
        [Validation(Required=false)]
        public string LocalModifiedAt { get; set; }

        /// <summary>
        /// The name of the file. The name can be up to 1,024 bytes in length based on the UTF-8 encoding rule and cannot end with a forward slash (/).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies whether to enable the parallel upload feature.
        /// </summary>
        [NameInMap("parallel_upload")]
        [Validation(Required=false)]
        public bool? ParallelUpload { get; set; }

        /// <summary>
        /// The ID of the parent directory. If you want to create a file or folder in the root directory, set this parameter to root.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("parent_file_id")]
        [Validation(Required=false)]
        public string ParentFileId { get; set; }

        /// <summary>
        /// The information about the file parts. You can specify up to 10,000 parts. By default, if you do not specify this parameter, only one part is returned.
        /// </summary>
        [NameInMap("part_info_list")]
        [Validation(Required=false)]
        public List<CreateFileRequestPartInfoList> PartInfoList { get; set; }
        public class CreateFileRequestPartInfoList : TeaModel {
            /// <summary>
            /// The MD5 hash value of the file part. This parameter is required when the MD5 hash value of the file part needs to be verified during part upload.
            /// </summary>
            [NameInMap("content_md5")]
            [Validation(Required=false)]
            public string ContentMd5 { get; set; }

            /// <summary>
            /// The SHA-1 hash value of the file content before the file part. This parameter takes effect only if the parallel upload feature is enabled.
            /// </summary>
            [NameInMap("parallel_sha1_ctx")]
            [Validation(Required=false)]
            public CreateFileRequestPartInfoListParallelSha1Ctx ParallelSha1Ctx { get; set; }
            public class CreateFileRequestPartInfoListParallelSha1Ctx : TeaModel {
                /// <summary>
                /// The first to fifth 32-bit variables of the SHA-1 hash value of the file content before the file part. This parameter takes effect only if the parallel upload feature is enabled.
                /// </summary>
                [NameInMap("h")]
                [Validation(Required=false)]
                public List<long?> H { get; set; }

                /// <summary>
                /// The size of the file content before the file part. Unit: bytes. The value must be a multiple of 64. This parameter takes effect only if the parallel upload feature is enabled.
                /// </summary>
                [NameInMap("part_offset")]
                [Validation(Required=false)]
                public long? PartOffset { get; set; }

            }

            /// <summary>
            /// The serial number of a file part. The number starts from 1.
            /// </summary>
            [NameInMap("part_number")]
            [Validation(Required=false)]
            public int? PartNumber { get; set; }

        }

        /// <summary>
        /// The SHA-1 hash value of the first 1 KB data of the file. This parameter is required if you perform instant file upload by using the pre-hashing feature. If the SHA-1 hash value is not matched on the cloud, the client does not need to calculate the SHA-1 hash value of the entire file.
        /// </summary>
        [NameInMap("pre_hash")]
        [Validation(Required=false)]
        public string PreHash { get; set; }

        /// <summary>
        /// The share ID. This parameter is required if the file is uploaded by using the share URL of the file.
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// The size of the file. Unit: bytes.
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// The type of the file. Valid values:
        /// 
        /// file folder
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The custom tags. You can specify up to 1,000 tags.
        /// </summary>
        [NameInMap("user_tags")]
        [Validation(Required=false)]
        public List<UserTag> UserTags { get; set; }

        /// <summary>
        /// The information about the video specified by the client.
        /// </summary>
        [NameInMap("video_media_metadata")]
        [Validation(Required=false)]
        public VideoMediaMetadata VideoMediaMetadata { get; set; }

    }

}
