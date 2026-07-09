// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveResourceListFilter : TeaModel {
        /// <summary>
        /// <para>Returns resources if a specified property contains any string in this array.</para>
        /// </summary>
        [NameInMap("contains")]
        [Validation(Required=false)]
        public List<string> Contains { get; set; }

    }

}
