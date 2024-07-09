// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DeleteUserVpcAuthorizationRequest : TeaModel {
        /// <summary>
        /// The authorization scope. Valid values:
        /// 
        /// *   NORMAL: general authorization
        /// *   NORMAL: cloud service-related authorization
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AuthorizedUserId")]
        [Validation(Required=false)]
        public long? AuthorizedUserId { get; set; }

    }

}
