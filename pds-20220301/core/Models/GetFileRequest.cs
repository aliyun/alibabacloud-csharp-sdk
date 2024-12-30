// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetFileRequest : TeaModel {
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
        /// <para>The fields to return.</para>
        /// <ol>
        /// <item><description>If this parameter is set to \*, all fields of the file except the fields that must be specified are returned.</description></item>
        /// <item><description>If only specific fields are required, you can specify the following fields: url, thumbnail, exif, cropping_suggestion, characteristic_hash, video_metadata, and video_preview_metadata. If multiple fields are required, separate them with commas (,). Example: url,thumbnail.</description></item>
        /// <item><description>The investigation_info field is returned only if you specify this field.</description></item>
        /// </ol>
        /// <para>By default, all fields except the fields that must be specified are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9520943DC264</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The share ID. If you want to manage a file by using a share link, carry the <c>x-share-token</c> header for authentication in the request and specify share_id. In this case, <c>drive_id</c> is invalid. Otherwise, use an <c>AccessKey pair</c> or <c>access token</c> for authentication and specify <c>drive_id</c>. You must specify one of <c>share_id</c> and <c>drive_id</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7JQX1FswpQ8</para>
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// <para>缩略图配置，可一次性返回最多5个缩略图，map的key可以自定义，返回时按key返回对应的缩略图链接</para>
        /// </summary>
        [NameInMap("thumbnail_processes")]
        [Validation(Required=false)]
        public Dictionary<string, ImageProcess> ThumbnailProcesses { get; set; }

        /// <summary>
        /// <para>The time when the file expires. Unit: seconds. Valid values: 10 to 14400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("url_expire_sec")]
        [Validation(Required=false)]
        public int? UrlExpireSec { get; set; }

    }

}
