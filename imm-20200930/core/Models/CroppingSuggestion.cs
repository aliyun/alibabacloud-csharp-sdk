// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CroppingSuggestion : TeaModel {
        /// <summary>
        /// <para>The aspect ratio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2:3</para>
        /// </summary>
        [NameInMap("AspectRatio")]
        [Validation(Required=false)]
        public string AspectRatio { get; set; }

        /// <summary>
        /// <para>The boundary of the cropping.</para>
        /// </summary>
        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

        /// <summary>
        /// <para>The confidence score. Valid values: 0 to 1. A higher score indicates greater confidence in the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.7079545259475708</para>
        /// </summary>
        [NameInMap("Confidence")]
        [Validation(Required=false)]
        public float? Confidence { get; set; }

    }

}
