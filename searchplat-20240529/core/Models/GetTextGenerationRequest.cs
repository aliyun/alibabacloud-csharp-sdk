// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetTextGenerationRequest : TeaModel {
        [NameInMap("csi_level")]
        [Validation(Required=false)]
        public string CsiLevel { get; set; }

        [NameInMap("enable_search")]
        [Validation(Required=false)]
        public bool? EnableSearch { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<GetTextGenerationRequestMessages> Messages { get; set; }
        public class GetTextGenerationRequestMessages : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
