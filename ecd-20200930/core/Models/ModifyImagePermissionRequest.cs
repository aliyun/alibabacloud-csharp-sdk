// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyImagePermissionRequest : TeaModel {
        /// <summary>
        /// The IDs of the recipient Alibaba Cloud accounts. You can share an image with up to 50 Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("AddAccount")]
        [Validation(Required=false)]
        public List<long?> AddAccount { get; set; }

        /// <summary>
        /// The ID of the image that you want to share.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the recipient Alibaba Cloud accounts from which you want to unshare the image. You can unshare an image from up to 50 Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("RemoveAccount")]
        [Validation(Required=false)]
        public List<long?> RemoveAccount { get; set; }

    }

}
