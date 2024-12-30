// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListUploadedPartsResponseBody : TeaModel {
        /// <summary>
        /// <para>The file ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>322fb07b975f4b0ae1b543fe8475eee4c19eb2b2</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If next_marker is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("next_part_number_marker")]
        [Validation(Required=false)]
        public string NextPartNumberMarker { get; set; }

        /// <summary>
        /// <para>Indicates whether the parallel upload feature is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("parallel_upload")]
        [Validation(Required=false)]
        public bool? ParallelUpload { get; set; }

        /// <summary>
        /// <para>The ID of the upload task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00166D06127B413BA1EC8ABB1144D101</para>
        /// </summary>
        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

        /// <summary>
        /// <para>The information about the file parts.</para>
        /// </summary>
        [NameInMap("uploaded_parts")]
        [Validation(Required=false)]
        public List<UploadPartInfo> UploadedParts { get; set; }

    }

}
