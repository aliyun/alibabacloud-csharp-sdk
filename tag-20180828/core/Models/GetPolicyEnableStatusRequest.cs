// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GetPolicyEnableStatusRequest : TeaModel {
        [NameInMap("OpenType")]
        [Validation(Required=false)]
        public string OpenType { get; set; }

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

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// The mode of the Tag Policy feature. This parameter specifies a filter condition for the query. Valid values:
        /// 
        /// *   USER: single-account mode
        /// *   RD: multi-account mode
        /// 
        /// For more information about the modes of the Tag Policy feature, see [Modes of the Tag Policy feature](~~417434~~).
        /// 
        /// >  The value of this parameter is not case-sensitive.
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
