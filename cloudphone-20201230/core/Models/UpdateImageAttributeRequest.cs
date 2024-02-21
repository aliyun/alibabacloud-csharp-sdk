// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class UpdateImageAttributeRequest : TeaModel {
        /// <summary>
        /// The IDs of the Alibaba Cloud accounts that are authorized to share images. You can specify up to 10 Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("AddAccount")]
        [Validation(Required=false)]
        public List<string> AddAccount { get; set; }

        /// <summary>
        /// The description of the custom image. The description must be 2 to 256 characters in length. It cannot start with `http://` or `https://`. By default, this parameter is empty, which indicates that the original description is retained.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The image ID.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The name of the custom image. The name must be 2 to 128 characters in length. The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-). It cannot start with `http://` or `https://`. By default, this parameter is empty, which indicates that the original name is retained.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the Alibaba Cloud accounts from which you want to revoke image sharing permissions. You can specify up to 10 Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("RemoveAccount")]
        [Validation(Required=false)]
        public List<string> RemoveAccount { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
