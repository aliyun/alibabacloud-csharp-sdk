// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ResourceLimitDetails : TeaModel {
        /// <summary>
        /// <para>The GC level.</para>
        /// </summary>
        [NameInMap("GCLevel")]
        [Validation(Required=false)]
        public string GCLevel { get; set; }

        /// <summary>
        /// <para>The resource limit details.</para>
        /// </summary>
        [NameInMap("ResourceLimit")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResourceLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore the resource check.</para>
        /// </summary>
        [NameInMap("ShouldIgnoreResourceCheck")]
        [Validation(Required=false)]
        public bool? ShouldIgnoreResourceCheck { get; set; }

    }

}
