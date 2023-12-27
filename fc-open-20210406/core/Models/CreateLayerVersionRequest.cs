// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateLayerVersionRequest : TeaModel {
        /// <summary>
        /// The layer code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public Code Code { get; set; }

        /// <summary>
        /// The runtimes that are supported by the layer.
        /// </summary>
        [NameInMap("compatibleRuntime")]
        [Validation(Required=false)]
        public List<string> CompatibleRuntime { get; set; }

        /// <summary>
        /// The layer description. The description can be up to 256 characters in length.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
