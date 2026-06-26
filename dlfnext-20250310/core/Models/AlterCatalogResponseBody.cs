// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class AlterCatalogResponseBody : TeaModel {
        /// <summary>
        /// <para>The unchanged items.</para>
        /// </summary>
        [NameInMap("missing")]
        [Validation(Required=false)]
        public List<string> Missing { get; set; }

        /// <summary>
        /// <para>The deleted items.</para>
        /// </summary>
        [NameInMap("removed")]
        [Validation(Required=false)]
        public List<string> Removed { get; set; }

        /// <summary>
        /// <para>The updated items.</para>
        /// </summary>
        [NameInMap("updated")]
        [Validation(Required=false)]
        public List<string> Updated { get; set; }

    }

}
