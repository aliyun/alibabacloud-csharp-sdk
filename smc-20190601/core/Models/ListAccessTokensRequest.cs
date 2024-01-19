// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class ListAccessTokensRequest : TeaModel {
        /// <summary>
        /// The information about activation codes.
        /// </summary>
        [NameInMap("AccessTokenId")]
        [Validation(Required=false)]
        public List<string> AccessTokenId { get; set; }

        /// <summary>
        /// The name of the activation code.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The status of the activation code. Valid values:
        /// 
        /// *   activated
        /// *   unactivated
        /// *   expired
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
