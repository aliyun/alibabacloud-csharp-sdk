// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateLayerVersionResponseBody : TeaModel {
        /// <summary>
        /// The access mode of the layer. Digit 0 specifies that the layer is private and digit 1 specifies that the layer is public. By default, public layers are public. Custom layers can be set to private or public.
        /// </summary>
        [NameInMap("acl")]
        [Validation(Required=false)]
        public int? Acl { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the layer.
        /// </summary>
        [NameInMap("arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// The information about the layer code package.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public OutputCodeLocation Code { get; set; }

        /// <summary>
        /// The CRC-64 value of the layer code package. The value is calculated based on the **ECMA-182 **standard.
        /// </summary>
        [NameInMap("codeChecksum")]
        [Validation(Required=false)]
        public string CodeChecksum { get; set; }

        /// <summary>
        /// The size of the layer code package. Unit: bytes.
        /// </summary>
        [NameInMap("codesize")]
        [Validation(Required=false)]
        public long? Codesize { get; set; }

        /// <summary>
        /// The runtimes that are supported by the layer.
        /// </summary>
        [NameInMap("compatibleRuntime")]
        [Validation(Required=false)]
        public List<string> CompatibleRuntime { get; set; }

        /// <summary>
        /// The time when the layer version was created. The time is in the yyyy-MM-ddTHH:mm:ssZ format.
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The description of the layer version.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The layer name.
        /// </summary>
        [NameInMap("layerName")]
        [Validation(Required=false)]
        public string LayerName { get; set; }

        /// <summary>
        /// The layer version.
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
