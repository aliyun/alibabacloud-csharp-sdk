// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DeleteUserRequest : TeaModel {
        [NameInMap("TransferUserId")]
        [Validation(Required=false)]
        public string TransferUserId { get; set; }

        /// <summary>
        /// Deletes a user from a specified organization.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
