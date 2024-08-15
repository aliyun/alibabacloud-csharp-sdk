// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class MoveAccountRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud account ID of the member that you want to move.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The ID of the destination folder.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationFolderId")]
        [Validation(Required=false)]
        public string DestinationFolderId { get; set; }

    }

}
