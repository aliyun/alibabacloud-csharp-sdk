// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteEditingProjectMaterialsRequest : TeaModel {
        /// <summary>
        /// 素材ID
        /// </summary>
        [NameInMap("MaterialIds")]
        [Validation(Required=false)]
        public string MaterialIds { get; set; }

        /// <summary>
        /// 素材类型
        /// </summary>
        [NameInMap("MaterialType")]
        [Validation(Required=false)]
        public string MaterialType { get; set; }

        /// <summary>
        /// 云剪辑工程ID
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
