// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryTagInfoBySelectionRequest : TeaModel {
        /// <summary>
        /// The industry ID.
        /// </summary>
        [NameInMap("IndustryId")]
        [Validation(Required=false)]
        public long? IndustryId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The scene ID.
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// The tag ID.
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public long? TagId { get; set; }

    }

}
