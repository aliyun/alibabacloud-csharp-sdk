// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class CreateFpShotDBRequest : TeaModel {
        /// <summary>
        /// The configurations of the media fingerprint library. By default, this parameter is left empty. You can customize the configurations based on your business requirements. The value must be a string in the JSON format.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The description of the media fingerprint library.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The model ID of the media fingerprint library. To create a text fingerprint library, set the parameter to **11**. To create a video fingerprint library, set the parameter to **12**. To create an audio fingerprint library, set the parameter to **13**. To create an image fingerprint library, set the parameter to **14**.
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public int? ModelId { get; set; }

        /// <summary>
        /// The name of the media fingerprint library.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
