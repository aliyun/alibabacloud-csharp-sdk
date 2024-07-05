// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetEditingProjectMaterialsRequest : TeaModel {
        /// <summary>
        /// The ID of the media asset. You can specify IDs of media assets such as videos, images, or auxiliary media assets. Separate multiple IDs with commas (,).
        /// 
        /// This parameter is required.
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
