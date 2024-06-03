// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class DeleteMFADeviceForUserRequest : TeaModel {
        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The ID of the MFA device.
        /// 
        /// You can call the [ListMFADevicesForUser](https://help.aliyun.com/document_detail/333531.html) operation to query the IDs of MFA devices.
        /// </summary>
        [NameInMap("MFADeviceId")]
        [Validation(Required=false)]
        public string MFADeviceId { get; set; }

        /// <summary>
        /// The ID of the user.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
