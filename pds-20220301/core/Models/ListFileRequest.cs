// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListFileRequest : TeaModel {
        /// <summary>
        /// <para>The category of the file. Valid values:</para>
        /// <para>app: installation package. zip: compressed package. image: image. doc: document. video: video. audio: audio. others: other files.</para>
        /// <para>By default, files of all categories are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

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
        /// <item><description>If only specific fields are required, you can specify the following fields: url, exif, cropping_suggestion, characteristic_hash, video_metadata, and video_preview_metadata. If multiple fields are required, separate them with commas (,). Example: url,exif.</description></item>
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
        /// <para>The maximum number of results to return. Valid values: 1 to 100.</para>
        /// <para>The number of returned results must be less than or equal to the specified number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of marker.\
        /// By default, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The sorting field.</para>
        /// <para>Default value: created_at.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>updated_at</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>sorts the results based on the time when the file was last modified</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// <item><description><para>size</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>sorts the results based on the size of the file</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// <item><description><para>name</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>sorts the results based on the name of the file</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// <item><description><para>created_at</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>sorts the results based on the time when the file was created</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>updated_at</para>
        /// </summary>
        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The sorting direction. Valid values:</para>
        /// <para>ASC: ascending order. DESC: descending order.</para>
        /// <para>Default value: ASC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("order_direction")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// <para>The ID of the parent folder. If the parent folder is a root directory, set this parameter to root.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("parent_file_id")]
        [Validation(Required=false)]
        public string ParentFileId { get; set; }

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
        /// <para>The state of the file. Valid values:</para>
        /// <para>available: Only normal files are returned. uploading: Only files that are being uploaded are returned.</para>
        /// <para>By default, only files in the available state are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>available</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The thumbnail configurations. Up to five thumbnails can be returned at a time. The value contains key-value pairs. You can customize the keys. The URL of a thumbnail is returned based on the key.</para>
        /// </summary>
        [NameInMap("thumbnail_processes")]
        [Validation(Required=false)]
        public Dictionary<string, ImageProcess> ThumbnailProcesses { get; set; }

        /// <summary>
        /// <para>The type of the file. Valid values:</para>
        /// <para>file: Only files are returned. folder: Only folders are returned.</para>
        /// <para>By default, files of all types are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
