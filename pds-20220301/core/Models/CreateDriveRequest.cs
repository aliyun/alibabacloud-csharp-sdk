// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateDriveRequest : TeaModel {
        /// <summary>
        /// Specifies whether the drive is the default drive. Default value: false.
        /// </summary>
        [NameInMap("default")]
        [Validation(Required=false)]
        public bool? Default { get; set; }

        /// <summary>
        /// The description of the drive. The description can be up to 1,024 characters in length.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the drive. The name can be up to 128 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("drive_name")]
        [Validation(Required=false)]
        public string DriveName { get; set; }

        /// <summary>
        /// The type of the drive. Set the value to normal.
        /// </summary>
        [NameInMap("drive_type")]
        [Validation(Required=false)]
        public string DriveType { get; set; }

        /// <summary>
        /// The owner of the drive.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// The type of the owner. Valid values:
        /// 
        /// user and group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("owner_type")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// The state of the drive. Valid values:
        /// 
        /// enabled and disabled.
        /// 
        /// Default value: enabled.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The total size of the drive. Unit: bytes. By default, the size is unlimited.
        /// </summary>
        [NameInMap("total_size")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

    }

}
