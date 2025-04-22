// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListFileRequest : TeaModel {
        /// <summary>
        /// <para>The file category. Valid values:</para>
        /// <para>app: installation package zip: compressed package image doc: document video audio others</para>
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
        /// <para>The field that is used to return additional information about a child subject. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>url: returns the URL of the thumbnail of a file in the response.</description></item>
        /// <item><description>exif: returns the Exchangeable Image File Format (EXIF) data of a file in the response.</description></item>
        /// <item><description>cropping_suggestion: returns the cropping suggestion on a file in the response.</description></item>
        /// <item><description>characteristic_hash: returns the characteristic hash value of a file in the response.</description></item>
        /// <item><description>video_metadata: returns the metadata of a video file, such as the video duration, bitrate, height, and width, in the response.</description></item>
        /// <item><description>video_preview_metadata: returns the transcoding information of a video file, such as the transcoding specification for each definition, in the response.</description></item>
        /// <item><description>investigation_info: returns the investigation information in the response.</description></item>
        /// <item><description>dir_size: returns the statistics on each subfolder in the response.</description></item>
        /// <item><description>user_tags: returns the user tags of each child subject in the response.</description></item>
        /// </list>
        /// <para>You can specify multiple fields by separating them with commas (,). Example: &quot;url,dir_size,user_tags&quot;.</para>
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
        /// <para>The number of returned entries must be less than or equal to the value of this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The name of the entry after which the list begins. Entries whose names are alphabetically after the value of this parameter are returned. If you do not specify this parameter, all entries are returned.\
        /// This parameter is left empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The sorting field. Valid values:</para>
        /// <para>created_at: sorts the entries by creation time. updated_at: sorts the entries by update time. size: sorts the entries by file size. name: sorts the entries by file name.</para>
        /// <para>Default value: created_at.</para>
        /// <para>Enumeration:</para>
        /// <list type="bullet">
        /// <item><description>updated_at: update time</description></item>
        /// <item><description>size: file size</description></item>
        /// <item><description>name: file name</description></item>
        /// <item><description>created_at: creation time</description></item>
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
        /// <para>ASC: ascending order DESC: descending order</para>
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
        /// <para>The share ID. If you want to share a file, carry the <c>x-share-token</c> header for authentication in the request and specify share_id. In this case, <c>drive_id</c> is invalid. Otherwise, use an <c>AccessKey pair</c> or <c>access token</c> for authentication and specify <c>drive_id</c>. You must specify one of <c>share_id</c> and <c>drive_id</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7JQX1FswpQ8</para>
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// <para>The state of the files to return. Valid values:</para>
        /// <para>available: returns only normal files. uploading: returns only files that are being uploaded.</para>
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
        /// <para>The file type. Valid values:</para>
        /// <para>file: returns only files. folder: returns only folders.</para>
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
