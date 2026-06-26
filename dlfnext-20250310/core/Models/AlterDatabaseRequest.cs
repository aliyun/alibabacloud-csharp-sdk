// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class AlterDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The items to delete.</para>
        /// </summary>
        [NameInMap("removals")]
        [Validation(Required=false)]
        public List<string> Removals { get; set; }

        /// <summary>
        /// <para>The items to update.</para>
        /// </summary>
        [NameInMap("updates")]
        [Validation(Required=false)]
        public Dictionary<string, string> Updates { get; set; }

    }

}
