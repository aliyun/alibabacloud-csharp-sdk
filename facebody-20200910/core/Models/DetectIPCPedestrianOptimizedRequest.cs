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
        /// <summary>
        /// image data
        /// </summary>
        [NameInMap("imageData")]
        [Validation(Required=false)]
        public byte[] ImageData { get; set; }

        /// <summary>
        /// image width
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

        /// <summary>
        /// image height
        /// </summary>
        [NameInMap("height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

    }

}
