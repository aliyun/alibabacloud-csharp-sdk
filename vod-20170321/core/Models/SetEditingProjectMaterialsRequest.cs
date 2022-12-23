// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetEditingProjectMaterialsRequest : TeaModel {
        /// <summary>
        /// The ID of the material. A material is a media asset, such as a video, an image, or an auxiliary media asset. Separate multiple material IDs with commas (,).
        /// </summary>
        [NameInMap("MaterialIds")]
        [Validation(Required=false)]
        public string MaterialIds { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The ID of the online editing project.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

    }

}
