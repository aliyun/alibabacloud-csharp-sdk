// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class EcomVideoRecreationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The input parameters for video remix.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        /// <summary>
        /// <para>The output specifications for the final video.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string OutputShrink { get; set; }

    }

}
