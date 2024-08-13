// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddEditingProjectMaterialsRequest : TeaModel {
        /// <summary>
        /// The ID of the material. Separate multiple material IDs with commas (,). You can specify up to 10 IDs.
        /// 
        /// >  If you specify multiple materials, make sure that the materials are of the same type as specified in MaterialType.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaterialIds")]
        [Validation(Required=false)]
        public string MaterialIds { get; set; }

        /// <summary>
        /// The type of the material. Valid values:
        /// 
        /// *   **video**
        /// *   **audio**
        /// *   **image**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaterialType")]
        [Validation(Required=false)]
        public string MaterialType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The ID of the online editing project.
        /// 
        /// This parameter is required.
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
