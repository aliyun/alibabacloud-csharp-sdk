// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GenerateConfigRuleReportRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID. Set the value to cn-shanghai.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The ID of the object.
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// The type of the object. Valid values:
        /// 
        /// *   USER: the current logon account. This value is available if you use the Tag Policy feature in single-account mode.
        /// *   ROOT: the Root folder in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
        /// *   FOLDER: a folder other than the Root folder in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
        /// *   ACCOUNT: a member in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
        /// 
        /// >  The value of this parameter is not case-sensitive.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// The mode of the Tag Policy feature. Valid values:
        /// 
        /// *   USER: single-account mode
        /// *   RD: multi-account mode
        /// 
        /// For more information about the modes of the Tag Policy feature, see [Modes of the Tag Policy feature](~~417434~~).
        /// 
        /// >  This parameter is required if the management account of your resource directory is used to enable the Tag Policy feature in both single-account mode and multi-account mode. The value of this parameter is not case-sensitive.
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
