// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class KdtreeOption : TeaModel {
        [NameInMap("CompressionLevel")]
        [Validation(Required=false)]
        public int? CompressionLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>draco</para>
        /// </summary>
        [NameInMap("LibraryName")]
        [Validation(Required=false)]
        public string LibraryName { get; set; }

        [NameInMap("QuantizationBits")]
        [Validation(Required=false)]
        public int? QuantizationBits { get; set; }

    }

}
