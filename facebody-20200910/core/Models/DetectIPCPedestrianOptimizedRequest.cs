/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20200910.Models
{
    public class DetectIPCPedestrianOptimizedRequest : TeaModel {
        [NameInMap("height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        [NameInMap("imageData")]
        [Validation(Required=false)]
        public byte[] ImageData { get; set; }

        [NameInMap("width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
