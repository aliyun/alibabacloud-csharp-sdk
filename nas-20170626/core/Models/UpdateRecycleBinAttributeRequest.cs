// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class UpdateRecycleBinAttributeRequest : TeaModel {
        /// <summary>
        /// The ID of the file system.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The retention period of the files in the recycle bin. Unit: days.
        /// 
        /// Valid values: 1 to 180.
        /// 
        /// Default value: 3.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReservedDays")]
        [Validation(Required=false)]
        public long? ReservedDays { get; set; }

    }

}
