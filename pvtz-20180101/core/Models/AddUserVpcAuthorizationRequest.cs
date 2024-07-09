// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class AddUserVpcAuthorizationRequest : TeaModel {
        /// <summary>
        /// The authorization method. Valid values:
        /// 
        /// *   AUTH_CODE: An authorization code is used to associate VPCs across accounts. The system checks whether the value of AuthCode is valid.
        /// *   RESOURCE_DIRECTORY: A resource directory is used to associate VPCs across accounts. The system checks whether the value of AuthorizedUserId and the current account are in the same resource directory.
        /// *   If this parameter is empty, an authorization code is used to associate VPCs across accounts.
        /// </summary>
        [NameInMap("AuthChannel")]
        [Validation(Required=false)]
        public string AuthChannel { get; set; }

        /// <summary>
        /// The verification code.
        /// 
        /// This parameter is required when AuthType is set to NORMAL or is left empty and AuthChannel is set to AUTH_CODE or is left empty.
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// The authorization scope. Valid values:
        /// 
        /// *   NORMAL: general authorization.
        /// *   CLOUD_PRODUCT: cloud service-related authorization
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
