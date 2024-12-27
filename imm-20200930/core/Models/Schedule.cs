// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Schedule : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0.97</para>
        /// </summary>
        [NameInMap("Gamma")]
        [Validation(Required=false)]
        public float? Gamma { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>StepLR</para>
        /// </summary>
        [NameInMap("LRScheduler")]
        [Validation(Required=false)]
        public string LRScheduler { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StepSize")]
        [Validation(Required=false)]
        public long? StepSize { get; set; }

    }

}
