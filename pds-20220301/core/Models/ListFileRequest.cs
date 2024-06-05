// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListFileRequest : TeaModel {
        /// <summary>
        /// The category of the file. Valid values:
        /// 
        /// app: installation package. zip: compressed package. image: image. doc: document. video: video. audio: audio. others: other files.
        /// 
        /// By default, files of all categories are returned.
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The drive ID.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// The fields to return.
        /// 
        /// 1.  If this parameter is set to \\*, all fields of the file except the fields that must be specified are returned.
        /// 2.  If only specific fields are required, you can specify the following fields: url, exif, cropping_suggestion, characteristic_hash, video_metadata, and video_preview_metadata. If multiple fields are required, separate them with commas (,). Example: url,exif.
        /// 3.  The investigation_info field is returned only if you specify this field.
        /// 
        /// By default, all fields except the fields that must be specified are returned.
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// The maximum number of results to return. Valid values: 1 to 100.
        /// 
        /// The number of returned results must be less than or equal to the specified number.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of marker.\\
        /// By default, this parameter is empty.
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The sorting field.
        /// 
        /// Default value: created_at.
        /// 
        /// Valid values:
        /// 
        /// *   updated_at
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     sorts the results based on the time when the file was last modified
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   size
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     sorts the results based on the size of the file
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   name
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     sorts the results based on the name of the file
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   created_at
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     sorts the results based on the time when the file was created
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// </summary>
        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The sorting direction. Valid values:
        /// 
        /// ASC: ascending order. DESC: descending order.
        /// 
        /// Default value: ASC.
        /// </summary>
        [NameInMap("order_direction")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// The ID of the parent folder. If the parent folder is a root directory, set this parameter to root.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("parent_file_id")]
        [Validation(Required=false)]
        public string ParentFileId { get; set; }

        /// <summary>
        /// The share ID. If you want to manage a file by using a share link, carry the `x-share-token` header for authentication in the request and specify share_id. In this case, `drive_id` is invalid. Otherwise, use an `AccessKey pair` or `access token` for authentication and specify `drive_id`. You must specify one of `share_id` and `drive_id`.
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// The state of the file. Valid values:
        /// 
        /// available: Only normal files are returned. uploading: Only files that are being uploaded are returned.
        /// 
        /// By default, only files in the available state are returned.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The thumbnail configurations. Up to five thumbnails can be returned at a time. The value contains key-value pairs. You can customize the keys. The URL of a thumbnail is returned based on the key.
        /// </summary>
        [NameInMap("thumbnail_processes")]
        [Validation(Required=false)]
        public Dictionary<string, ImageProcess> ThumbnailProcesses { get; set; }

        /// <summary>
        /// The type of the file. Valid values:
        /// 
        /// file: Only files are returned. folder: Only folders are returned.
        /// 
        /// By default, files of all types are returned.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
