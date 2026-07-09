// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveResourceGlobalScopeFilter : TeaModel {
        /// <summary>
        /// <para>Specifies whether to retrieve only resources that are exclusive to the global scope.</para>
        /// </summary>
        [NameInMap("eq")]
        [Validation(Required=false)]
        public bool? Eq { get; set; }

    }

}
