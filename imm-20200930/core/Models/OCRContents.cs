// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class OCRContents : TeaModel {
        /// <summary>
        /// <para>The boundary information.</para>
        /// </summary>
        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

        /// <summary>
        /// <para>The confidence level of the content. Valid values: 0 to 1. The value 0 indicates the lowest confidence level. The value 1 indicates the highest confidence level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.8254936695098877</para>
        /// </summary>
        [NameInMap("Confidence")]
        [Validation(Required=false)]
        public float? Confidence { get; set; }

        /// <summary>
        /// <para>The content.</para>
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public string Contents { get; set; }

        /// <summary>
        /// <para>The BCP 47 language code. This parameter is not supported in the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-hans</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
