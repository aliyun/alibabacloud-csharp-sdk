// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyImageSharePermissionRequest : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account with which you want to share the image. You can specify multiple Alibaba Cloud IDs. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("AddAccounts")]
        [Validation(Required=false)]
        public string AddAccounts { get; set; }

        /// <summary>
        /// The ID of the image. You can specify only one image ID. Custom images and public images are supported.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account from which you want to unshare the image. You can specify only one Alibaba Cloud account ID.
        /// </summary>
        [NameInMap("RemoveAccounts")]
        [Validation(Required=false)]
        public string RemoveAccounts { get; set; }

    }

}
