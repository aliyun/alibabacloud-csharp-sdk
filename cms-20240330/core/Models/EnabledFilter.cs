// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class EnabledFilter : TeaModel {
        /// <summary>
        /// <para>The value to filter by. Set to <c>true</c> to return only enabled resources. Set to <c>false</c> to return only disabled resources.</para>
        /// </summary>
        [NameInMap("eq")]
        [Validation(Required=false)]
        public bool? Eq { get; set; }

    }

}
