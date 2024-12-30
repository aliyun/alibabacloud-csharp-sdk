// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetUploadUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the upload task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-11T16:34:36.977Z</para>
        /// </summary>
        [NameInMap("create_at")]
        [Validation(Required=false)]
        public string CreateAt { get; set; }

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
        /// <para>The file ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5d5b846942cf94fa72324c14a4bda34e81da635d</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The information about the file parts.</para>
        /// </summary>
        [NameInMap("part_info_list")]
        [Validation(Required=false)]
        public List<UploadPartInfo> PartInfoList { get; set; }

        /// <summary>
        /// <para>The ID of the upload task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10166D06127B413BA1EC8ABB1144D111</para>
        /// </summary>
        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
