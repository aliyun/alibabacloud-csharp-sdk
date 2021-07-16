// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GenerateProblemPictureUploadSignRequest : TeaModel {
        /// <summary>
        /// 文件名
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [NameInMap("fileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// 文件大小KB
        /// </summary>
        [NameInMap("fileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// 故障id
        /// </summary>
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

    }

}
