// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QuerySceneListShrinkRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("SceneStates")]
        [Validation(Required=false)]
        public string SceneStatesShrink { get; set; }

        [NameInMap("SceneTypes")]
        [Validation(Required=false)]
        public string SceneTypesShrink { get; set; }

        [NameInMap("TemplateInfoIds")]
        [Validation(Required=false)]
        public string TemplateInfoIdsShrink { get; set; }

    }

}
