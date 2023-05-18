// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class MoveAccountRequest : TeaModel {
        /// <summary>
        /// The ID of the account you want to move.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The ID of the destination folder.
        /// </summary>
        [NameInMap("DestinationFolderId")]
        [Validation(Required=false)]
        public string DestinationFolderId { get; set; }

    }

}
