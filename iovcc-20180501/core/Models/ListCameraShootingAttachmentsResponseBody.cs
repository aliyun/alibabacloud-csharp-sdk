// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListCameraShootingAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Attachments")]
        [Validation(Required=false)]
        public List<ListCameraShootingAttachmentsResponseBodyAttachments> Attachments { get; set; }
        public class ListCameraShootingAttachmentsResponseBodyAttachments : TeaModel {
            /// <summary>
            /// 主键id
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 文件id
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// 文件类型，0-图片，1-视频
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public long? FileType { get; set; }

            /// <summary>
            /// 文件名
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// 文件长度，单位为字节
            /// </summary>
            [NameInMap("FileLength")]
            [Validation(Required=false)]
            public long? FileLength { get; set; }

            /// <summary>
            /// 拍摄时间
            /// </summary>
            [NameInMap("ShootingTime")]
            [Validation(Required=false)]
            public long? ShootingTime { get; set; }

            /// <summary>
            /// 附件地址
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

        }

    }

}
