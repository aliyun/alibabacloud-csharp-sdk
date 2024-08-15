// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetAccountRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud account ID of the member.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Specifies whether to return the information of tags. Valid values:
        /// 
        /// *   false (default value)
        /// *   true
        /// </summary>
        [NameInMap("IncludeTags")]
        [Validation(Required=false)]
        public bool? IncludeTags { get; set; }

    }

}
