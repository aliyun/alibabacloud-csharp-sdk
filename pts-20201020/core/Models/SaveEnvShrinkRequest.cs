// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class SaveEnvShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The JMeter environment.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string EnvShrink { get; set; }

    }

}
