// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GeneratePictureUploadSignRequest : TeaModel {
        /// <summary>
        /// 文件
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<GeneratePictureUploadSignRequestFiles> Files { get; set; }
        public class GeneratePictureUploadSignRequestFiles : TeaModel {
            /// <summary>
            /// 文件名称
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// 文件大小
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// 文件类型
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

        }

        /// <summary>
        /// 资源id
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}
