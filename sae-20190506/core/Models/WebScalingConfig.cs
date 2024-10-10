// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebScalingConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaximumInstanceCount")]
        [Validation(Required=false)]
        public long? MaximumInstanceCount { get; set; }

        [NameInMap("MinimumInstanceCount")]
        [Validation(Required=false)]
        public long? MinimumInstanceCount { get; set; }

    }

}
