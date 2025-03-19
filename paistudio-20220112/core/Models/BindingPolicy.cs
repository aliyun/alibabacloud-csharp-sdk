// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class BindingPolicy : TeaModel {
        [NameInMap("ExcludeNodes")]
        [Validation(Required=false)]
        public List<string> ExcludeNodes { get; set; }

        [NameInMap("IncludeNodes")]
        [Validation(Required=false)]
        public List<string> IncludeNodes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("NodeSpecCount")]
        [Validation(Required=false)]
        public long? NodeSpecCount { get; set; }

    }

}
