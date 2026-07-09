// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveResourceTypeFilter : TeaModel {
        /// <summary>
        /// <para>The exact resource type to query. Returns only resources of this type.</para>
        /// </summary>
        [NameInMap("eq")]
        [Validation(Required=false)]
        public string Eq { get; set; }

    }

}
