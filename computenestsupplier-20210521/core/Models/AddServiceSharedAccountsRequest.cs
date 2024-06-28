/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class AddServiceSharedAccountsRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The service ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The shared account and permissions of the service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SharedAccounts")]
        [Validation(Required=false)]
        public List<AddServiceSharedAccountsRequestSharedAccounts> SharedAccounts { get; set; }
        public class AddServiceSharedAccountsRequestSharedAccounts : TeaModel {
            /// <summary>
            /// The permissions on the service. Valid values:
            /// 
            /// *   Deployable: Permissions to deploy the service.
            /// *   Accessible: Permissions to access the service.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

            /// <summary>
            /// The Alibaba Cloud account ID of the user.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("UserAliUid")]
            [Validation(Required=false)]
            public string UserAliUid { get; set; }

        }

        /// <summary>
        /// The share type of the service. Default value: SharedAccount. Valid values:
        /// 
        /// *   SharedAccount: The service is shared by multiple accounts.
        /// *   Reseller: The service is distributed.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
