// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ApmThresholdConfig : TeaModel {
        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        [NameInMap("threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

    }

}
