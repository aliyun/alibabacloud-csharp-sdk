// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class AlterShareResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clg-paimon-xxxx</para>
        /// </summary>
        [NameInMap("catalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// <para>The shared resources.</para>
        /// </summary>
        [NameInMap("shareResourceList")]
        [Validation(Required=false)]
        public List<ShareResource> ShareResourceList { get; set; }

    }

}
