// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListUploadedPartsResponseBody : TeaModel {
        /// <summary>
        /// The file ID.
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If next_marker is empty, no next page exists.
        /// </summary>
        [NameInMap("next_part_number_marker")]
        [Validation(Required=false)]
        public string NextPartNumberMarker { get; set; }

        /// <summary>
        /// Indicates whether the parallel upload feature is enabled.
        /// </summary>
        [NameInMap("parallel_upload")]
        [Validation(Required=false)]
        public bool? ParallelUpload { get; set; }

        /// <summary>
        /// The ID of the upload task.
        /// </summary>
        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

        /// <summary>
        /// The information about the file parts.
        /// </summary>
        [NameInMap("uploaded_parts")]
        [Validation(Required=false)]
        public List<UploadPartInfo> UploadedParts { get; set; }

    }

}
