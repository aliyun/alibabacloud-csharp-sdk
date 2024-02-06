// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AttachDiskRequest : TeaModel {
        /// <summary>
        /// Specifies whether the disk to be attached is released with the instance. Valid values:
        /// 
        /// *   true: The disk will be released when the ECS instance is released.
        /// *   false: The disk will be retained when the ECS instance is released.
        /// *   If you leave this parameter empty, the default value is used.
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public string DeleteWithInstance { get; set; }

        /// <summary>
        /// The ID of the disk to be attached. The cloud disk and the instance must belong to the same zone.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
