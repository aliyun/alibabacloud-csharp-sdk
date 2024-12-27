// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Optimization : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0.01</para>
        /// </summary>
        [NameInMap("LearningRate")]
        [Validation(Required=false)]
        public float? LearningRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SGD</para>
        /// </summary>
        [NameInMap("Optimizer")]
        [Validation(Required=false)]
        public string Optimizer { get; set; }

    }

}
