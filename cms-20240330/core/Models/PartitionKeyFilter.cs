// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PartitionKeyFilter : TeaModel {
        /// <summary>
        /// <para>Returns only items whose partition key value equals this string.</para>
        /// </summary>
        [NameInMap("eq")]
        [Validation(Required=false)]
        public string Eq { get; set; }

    }

}
