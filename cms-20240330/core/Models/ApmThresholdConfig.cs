// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ApmThresholdConfig : TeaModel {
        /// <summary>
        /// <para>The upper bound of the range.</para>
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        /// <summary>
        /// <para>The lower bound of the range.</para>
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        /// <summary>
        /// <para>The alert level.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The threshold. This parameter is required for APM_SIMPLE_CONDITION.</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

    }

}
