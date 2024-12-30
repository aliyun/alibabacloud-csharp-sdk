// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateFileRequest : TeaModel {
        /// <summary>
        /// <para>The processing method that is used if the file that you want to create has the same name as an existing file in the cloud. Valid values:</para>
        /// <para>ignore: allows you to create the file by using the same name as an existing file in the cloud.</para>
        /// <para>auto_rename: automatically renames the file that you want to create. By default, the current point in time is added to the end of the file name. Example: xxx_20060102_150405.</para>
        /// <para>refuse: does not create the file that you want to create but returns the information about the file that has the same name in the cloud.</para>
        /// <para>Default value: ignore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ignore</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("check_name_mode")]
        [Validation(Required=false)]
        public string CheckNameMode { get; set; }

        /// <summary>
        /// <para>The hash value of the file content. The value is calculated based on the algorithm specified by content_hash_name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C4A8D09CA3762AF61E59520943DC26494F8941B</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("content_hash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        /// <summary>
        /// <para>The name of the algorithm that is used to calculate the hash value of the file content. Only SHA1 is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha1</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("content_hash_name")]
        [Validation(Required=false)]
        public string ContentHashName { get; set; }

        /// <summary>
        /// <para>The type of the file content. Default value: application/oct-stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/json</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("content_type")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The description of the file. The description can be up to 1,024 characters in length. By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>重要文件</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The drive ID. This parameter is required if the file is not uploaded by using the share URL of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The file ID. This parameter is required if check_name_mode is set to ignore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9520943DC264</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>Specifies whether to hide the file or folder. By default, the file or folder is not hidden.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("hidden")]
        [Validation(Required=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// <para>The information about the image specified by the client.</para>
        /// </summary>
        [NameInMap("image_media_metadata")]
        [Validation(Required=false)]
        public ImageMediaMetadata ImageMediaMetadata { get; set; }

        /// <summary>
        /// <para>The time when the local file was created. By default, this parameter is left empty. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format based on the UTC+0 time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("local_created_at")]
        [Validation(Required=false)]
        public string LocalCreatedAt { get; set; }

        /// <summary>
        /// <para>The time when the local file was modified. By default, this parameter is left empty. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format based on the UTC+0 time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("local_modified_at")]
        [Validation(Required=false)]
        public string LocalModifiedAt { get; set; }

        /// <summary>
        /// <para>The name of the file. The name can be up to 1,024 bytes in length based on the UTF-8 encoding rule and cannot end with a forward slash (/).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.txt</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the parallel upload feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("parallel_upload")]
        [Validation(Required=false)]
        public bool? ParallelUpload { get; set; }

        /// <summary>
        /// <para>The ID of the parent directory. If you want to create a file or folder in the root directory, set this parameter to root.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fileid1</para>
        /// </summary>
        [NameInMap("parent_file_id")]
        [Validation(Required=false)]
        public string ParentFileId { get; set; }

        /// <summary>
        /// <para>The information about the file parts. You can specify up to 10,000 parts. By default, if you do not specify this parameter, only one part is returned.</para>
        /// </summary>
        [NameInMap("part_info_list")]
        [Validation(Required=false)]
        public List<CreateFileRequestPartInfoList> PartInfoList { get; set; }
        public class CreateFileRequestPartInfoList : TeaModel {
            /// <summary>
            /// <para>The MD5 hash value of the file part. This parameter is required when the MD5 hash value of the file part needs to be verified during part upload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASKJDJSKDJJSJDJS</para>
            /// </summary>
            [NameInMap("content_md5")]
            [Validation(Required=false)]
            public string ContentMd5 { get; set; }

            /// <summary>
            /// <para>The SHA-1 hash value of the file content before the file part. This parameter takes effect only if the parallel upload feature is enabled.</para>
            /// </summary>
            [NameInMap("parallel_sha1_ctx")]
            [Validation(Required=false)]
            public CreateFileRequestPartInfoListParallelSha1Ctx ParallelSha1Ctx { get; set; }
            public class CreateFileRequestPartInfoListParallelSha1Ctx : TeaModel {
                /// <summary>
                /// <para>The first to fifth 32-bit variables of the SHA-1 hash value of the file content before the file part. This parameter takes effect only if the parallel upload feature is enabled.</para>
                /// </summary>
                [NameInMap("h")]
                [Validation(Required=false)]
                public List<long?> H { get; set; }

                /// <summary>
                /// <para>The size of the file content before the file part. Unit: bytes. The value must be a multiple of 64. This parameter takes effect only if the parallel upload feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10240</para>
                /// </summary>
                [NameInMap("part_offset")]
                [Validation(Required=false)]
                public long? PartOffset { get; set; }

            }

            /// <summary>
            /// <para>The serial number of a file part. The number starts from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("part_number")]
            [Validation(Required=false)]
            public int? PartNumber { get; set; }

        }

        /// <summary>
        /// <para>The SHA-1 hash value of the first 1 KB data of the file. This parameter is required if you perform instant file upload by using the pre-hashing feature. If the SHA-1 hash value is not matched on the cloud, the client does not need to calculate the SHA-1 hash value of the entire file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C4A8D09CA3762AF61E59520943DC26494F89411</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pre_hash")]
        [Validation(Required=false)]
        public string PreHash { get; set; }

        /// <summary>
        /// <para>The share ID. This parameter is required if the file is uploaded by using the share URL of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7JQX1FswpQ8</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// <para>The size of the file. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The type of the file. Valid values:</para>
        /// <para>file folder</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The custom tags. You can specify up to 1,000 tags.</para>
        /// </summary>
        [NameInMap("user_tags")]
        [Validation(Required=false)]
        public List<UserTag> UserTags { get; set; }

        /// <summary>
        /// <para>The information about the video specified by the client.</para>
        /// </summary>
        [NameInMap("video_media_metadata")]
        [Validation(Required=false)]
        public VideoMediaMetadata VideoMediaMetadata { get; set; }

    }

}
