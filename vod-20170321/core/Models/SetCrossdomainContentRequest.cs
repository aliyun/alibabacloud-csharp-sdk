// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetCrossdomainContentRequest : TeaModel {
        /// <summary>
        /// The content of the cross-domain policy file. The file must be in the XML format and can contain up to 2,048 characters.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the resource owner.
        /// </summary>
        [NameInMap("ResourceRealOwnerId")]
        [Validation(Required=false)]
        public string ResourceRealOwnerId { get; set; }

        /// <summary>
        /// The URL of the Object Storage Service (OSS) bucket.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

    }

}
