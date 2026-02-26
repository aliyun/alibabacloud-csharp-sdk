// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Body : TeaModel {
        /// <summary>
        /// <para>The boundary of the human body.</para>
        /// </summary>
        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

        /// <summary>
        /// <para>The confidence level of the result. A higher value indicates greater confidence. Specifically, a value exceeding 0.8 signifies a high degree of confidence in the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.75</para>
        /// </summary>
        [NameInMap("Confidence")]
        [Validation(Required=false)]
        public float? Confidence { get; set; }

    }

}
