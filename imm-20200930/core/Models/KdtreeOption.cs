// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class KdtreeOption : TeaModel {
        /// <summary>
        /// <para>The compression level. Valid values: 0 to 10. A greater value specifies a higher compression ratio and ensures better detail effects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CompressionLevel")]
        [Validation(Required=false)]
        public int? CompressionLevel { get; set; }

        /// <summary>
        /// <para>The name of the library supported by a k-d tree. Set the value to draco. Default value: draco.</para>
        /// 
        /// <b>Example:</b>
        /// <para>draco</para>
        /// </summary>
        [NameInMap("LibraryName")]
        [Validation(Required=false)]
        public string LibraryName { get; set; }

        /// <summary>
        /// <para>The number of bits for quantization. Valid values: 0 to 31. A greater value ensures that more details are retained. A value of 0 specifies that vertex compression is not performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QuantizationBits")]
        [Validation(Required=false)]
        public int? QuantizationBits { get; set; }

    }

}
