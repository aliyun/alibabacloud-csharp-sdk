// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateLayerVersionResponseBody : TeaModel {
        /// <summary>
        /// Creates a layer version.
        /// </summary>
        [NameInMap("acl")]
        [Validation(Required=false)]
        public int? Acl { get; set; }

        [NameInMap("arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// The access mode of the layer.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public OutputCodeLocation Code { get; set; }

        /// <summary>
        /// Example 1
        /// </summary>
        [NameInMap("codeChecksum")]
        [Validation(Required=false)]
        public string CodeChecksum { get; set; }

        /// <summary>
        /// The size of the layer code package. Unit: Byte.
        /// </summary>
        [NameInMap("codesize")]
        [Validation(Required=false)]
        public long? Codesize { get; set; }

        /// <summary>
        /// Luoni
        /// </summary>
        [NameInMap("compatibleRuntime")]
        [Validation(Required=false)]
        public List<string> CompatibleRuntime { get; set; }

        /// <summary>
        /// Creates a layer version.
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The name of the layer.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The list of runtime environments that are supported by the layer.
        /// </summary>
        [NameInMap("layerName")]
        [Validation(Required=false)]
        public string LayerName { get; set; }

        /// <summary>
        /// The time when the layer version was created. The time follows the **yyyy-MM-ddTHH:mm:ssZ** format.
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
