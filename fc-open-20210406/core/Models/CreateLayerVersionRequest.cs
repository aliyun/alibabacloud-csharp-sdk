// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateLayerVersionRequest : TeaModel {
        /// <summary>
        /// The code of the layer.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public Code Code { get; set; }

        /// <summary>
        /// The list of runtime environments that are supported by the layer.
        /// </summary>
        [NameInMap("compatibleRuntime")]
        [Validation(Required=false)]
        public List<string> CompatibleRuntime { get; set; }

        /// <summary>
        /// The description of the layer.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
