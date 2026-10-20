// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class EcomVideoRecreationShrinkRequest : Darabonba.Model {
        /// <summary>
        /// <para>The input parameters for video variation generation.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        /// <summary>
        /// <para>The output specifications for the generated video.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string OutputShrink { get; set; }

    }

}

