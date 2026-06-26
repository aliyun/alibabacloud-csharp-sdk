// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListPartitionsByNamesRequest : TeaModel {
        /// <summary>
        /// <para>分区规格列表。</para>
        /// </summary>
        [NameInMap("specs")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Specs { get; set; }

    }

}
