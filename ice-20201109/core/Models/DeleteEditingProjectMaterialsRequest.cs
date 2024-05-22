// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteEditingProjectMaterialsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaterialIds")]
        [Validation(Required=false)]
        public string MaterialIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaterialType")]
        [Validation(Required=false)]
        public string MaterialType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
