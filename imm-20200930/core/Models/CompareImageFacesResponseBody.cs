// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CompareImageFacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F73AC982-2B9E-4ECD-AED5-F8331C5******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The face similarity. A larger value indicates a higher face similarity. Valid values: 0 to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.8848152756690983</para>
        /// </summary>
        [NameInMap("Similarity")]
        [Validation(Required=false)]
        public float? Similarity { get; set; }

    }

}
