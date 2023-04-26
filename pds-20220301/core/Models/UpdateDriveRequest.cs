// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateDriveRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("drive_name")]
        [Validation(Required=false)]
        public string DriveName { get; set; }

        /// <summary>
        /// 归属者
        /// 注意，当前只允许通过 ak 来修改个人 drive 的所有者。
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("total_size")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

    }

}
