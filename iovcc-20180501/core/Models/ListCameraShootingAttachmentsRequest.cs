// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListCameraShootingAttachmentsRequest : TeaModel {
        /// <summary>
        /// 项目ID
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 终端设备id
        /// </summary>
        [NameInMap("EdgeDeviceId")]
        [Validation(Required=false)]
        public string EdgeDeviceId { get; set; }

        /// <summary>
        /// 拍摄记录ID
        /// </summary>
        [NameInMap("ShootingRecordId")]
        [Validation(Required=false)]
        public long? ShootingRecordId { get; set; }

    }

}
