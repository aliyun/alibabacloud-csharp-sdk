// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateFileResponseBody : TeaModel {
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
        /// <para>The drive ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>Indicates whether the file exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("exist")]
        [Validation(Required=false)]
        public bool? Exist { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fileid1</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.txt</para>
        /// </summary>
        [NameInMap("file_name")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The ID of the parent directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fileid5</para>
        /// </summary>
        [NameInMap("parent_file_id")]
        [Validation(Required=false)]
        public string ParentFileId { get; set; }

        /// <summary>
        /// <para>The information about the file parts.</para>
        /// </summary>
        [NameInMap("part_info_list")]
        [Validation(Required=false)]
        public List<UploadPartInfo> PartInfoList { get; set; }

        /// <summary>
        /// <para>Indicates whether the file is instantly uploaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("rapid_upload")]
        [Validation(Required=false)]
        public bool? RapidUpload { get; set; }

        /// <summary>
        /// <para>The state of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uploading</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the upload task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uploadid1</para>
        /// </summary>
        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
