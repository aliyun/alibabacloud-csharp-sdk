// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeRecoverableOtsInstancesRequest : TeaModel {
        /// <summary>
        /// The role name created in the RAM of the original account used for cross-account backup.
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// The type of cross-account backup. Supported:
        /// * SELF_ACCOUNT: backup of this account
        /// * CROSS_ACCOUNT: Cross-account backup
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// The Alibaba Cloud Uid of the original account used to cross accounts.
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

    }

}
