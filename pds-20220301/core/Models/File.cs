// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class File : TeaModel {
        /// <summary>
        /// <para>The permissions.</para>
        /// </summary>
        [NameInMap("action_list")]
        [Validation(Required=false)]
        public List<string> ActionList { get; set; }

        /// <summary>
        /// <para>The remaining time until the file is automatically deleted from the recycle bin (if in it).</para>
        /// </summary>
        [NameInMap("auto_delete_left_sec")]
        [Validation(Required=false)]
        public long? AutoDeleteLeftSec { get; set; }

        /// <summary>
        /// <para>The category. Drive and Photo Service (PDS) classifies files based on their extensions and mime-type. The supported categories include doc, image, audio, and video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The hash value of the content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EA4942AA8761213890A5C386F88E6464D2C31CA3</para>
        /// </summary>
        [NameInMap("content_hash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        /// <summary>
        /// <para>The name of the hash algorithm. Set the value to sha1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha1</para>
        /// </summary>
        [NameInMap("content_hash_name")]
        [Validation(Required=false)]
        public string ContentHashName { get; set; }

        /// <summary>
        /// <para>The type of the content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/json</para>
        /// </summary>
        [NameInMap("content_type")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>crc64</para>
        /// 
        /// <b>Example:</b>
        /// <para>3574582125365864471</para>
        /// </summary>
        [NameInMap("crc64_hash")]
        [Validation(Required=false)]
        public string Crc64Hash { get; set; }

        /// <summary>
        /// <para>The time when the file was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The description of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image file</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The information about the folder structure. This parameter is returned only if you include the dir_size field in the fields parameter by calling the ListFile or GetFile operation.</para>
        /// </summary>
        [NameInMap("dir_size_info")]
        [Validation(Required=false)]
        public FileDirSizeInfo DirSizeInfo { get; set; }
        public class FileDirSizeInfo : TeaModel {
            /// <summary>
            /// <para>The number of all descendant folders in the folder, which is calculated recursively.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("dir_count")]
            [Validation(Required=false)]
            public long? DirCount { get; set; }

            /// <summary>
            /// <para>The number of all descendant files in the folder, which is calculated recursively.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("file_count")]
            [Validation(Required=false)]
            public long? FileCount { get; set; }

        }

        /// <summary>
        /// <para>The domain ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj1</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The download URL. The default validity period of the download URL is 15 minutes. If the URL expires, you can obtain the URL by calling the GetFile operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx">https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx</a></para>
        /// </summary>
        [NameInMap("download_url")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The drive ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The file name extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>txt</para>
        /// </summary>
        [NameInMap("file_extension")]
        [Validation(Required=false)]
        public string FileExtension { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5d79206586bb5dd69fb34c349282718146c55da7</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>Specifies whether to hide the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hidden")]
        [Validation(Required=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// <para>The file ID path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id1/id2</para>
        /// </summary>
        [NameInMap("id_path")]
        [Validation(Required=false)]
        public string IdPath { get; set; }

        /// <summary>
        /// <para>The image metadata. This parameter takes effect only if the value-added image processing feature is enabled.</para>
        /// </summary>
        [NameInMap("image_media_metadata")]
        [Validation(Required=false)]
        public ImageMediaMetadata ImageMediaMetadata { get; set; }

        /// <summary>
        /// <para>The labels of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;label1:1&quot;, &quot;label2:2&quot;]</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// <para>The time when the local file was created. The time refers to the local time when the file was uploaded. This parameter helps identify the local upload time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("local_created_at")]
        [Validation(Required=false)]
        public string LocalCreatedAt { get; set; }

        /// <summary>
        /// <para>The time when the local file was modified. The time refers to the local time when the modified file was uploaded. This parameter helps identify the local update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("local_modified_at")]
        [Validation(Required=false)]
        public string LocalModifiedAt { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.mov</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The file path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root/f1/f2</para>
        /// </summary>
        [NameInMap("name_path")]
        [Validation(Required=false)]
        public string NamePath { get; set; }

        /// <summary>
        /// <para>The parent folder ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3d5b846942cf94fa72324c8a4bda34e81da635a</para>
        /// </summary>
        [NameInMap("parent_file_id")]
        [Validation(Required=false)]
        public string ParentFileId { get; set; }

        /// <summary>
        /// <para>The version ID. If a file that has the same file ID with an existing one is uploaded, a new version ID is generated for the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5d5b846942cf94fa72324c14a4bda34e81da635d</para>
        /// </summary>
        [NameInMap("revision_id")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

        /// <summary>
        /// <para>The file size</para>
        /// <para>or folder size. The folder size is calculated based on all descendant files and folders in the folder. Note: The folder size can be returned only when you call the ListFile or GetFile operation and include the dir_size field in the fields parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>Specifies whether to add the file to favorites.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("starred")]
        [Validation(Required=false)]
        public bool? Starred { get; set; }

        /// <summary>
        /// <para>The status of the file. Only files and directories in the available state can be accessed. If you call the GetFile operation to obtain a file that is in the uploading state, a response indicating that the file does not exist is returned. If you call the ListFile operation to query files, files in the uploading state are not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>available</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The URL of the thumbnail. This parameter is deprecated and we recommend that you use thumbnail_urls.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx">https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx</a></para>
        /// </summary>
        [NameInMap("thumbnail")]
        [Validation(Required=false)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// <para>The information about the returned thumbnail. The value corresponds to the key that is specified by thumbnail_processes.</para>
        /// </summary>
        [NameInMap("thumbnail_urls")]
        [Validation(Required=false)]
        public Dictionary<string, string> ThumbnailUrls { get; set; }

        /// <summary>
        /// <para>The time when the file was put into the recycle bin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("trashed_at")]
        [Validation(Required=false)]
        public string TrashedAt { get; set; }

        /// <summary>
        /// <para>The file type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>file</description></item>
        /// <item><description>folder</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The time when the file was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The upload ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C9DCFE5A82644AC7A02DB74C30C934A6</para>
        /// </summary>
        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

        /// <summary>
        /// <para>The custom tags.</para>
        /// </summary>
        [NameInMap("user_tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> UserTags { get; set; }

        /// <summary>
        /// <para>The audio and video information.</para>
        /// </summary>
        [NameInMap("video_media_metadata")]
        [Validation(Required=false)]
        public VideoMediaMetadata VideoMediaMetadata { get; set; }

    }

}
