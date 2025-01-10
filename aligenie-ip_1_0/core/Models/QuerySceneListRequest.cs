// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QuerySceneListRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af7***536</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("SceneStates")]
        [Validation(Required=false)]
        public List<int?> SceneStates { get; set; }

        [NameInMap("SceneTypes")]
        [Validation(Required=false)]
        public List<string> SceneTypes { get; set; }

        [NameInMap("TemplateInfoIds")]
        [Validation(Required=false)]
        public List<string> TemplateInfoIds { get; set; }

    }

}
