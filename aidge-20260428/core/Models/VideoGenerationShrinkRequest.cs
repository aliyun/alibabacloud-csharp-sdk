// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class VideoGenerationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The product input.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        /// <summary>
        /// <para>The intent parameters. Currently unavailable.</para>
        /// </summary>
        [NameInMap("Intent")]
        [Validation(Required=false)]
        public string IntentShrink { get; set; }

        /// <summary>
        /// <para>The output parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string OutputShrink { get; set; }

    }

}
