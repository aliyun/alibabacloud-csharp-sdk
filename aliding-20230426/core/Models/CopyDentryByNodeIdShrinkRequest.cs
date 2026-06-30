// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CopyDentryByNodeIdShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        [NameInMap("ToNextNodeId")]
        [Validation(Required=false)]
        public string ToNextNodeId { get; set; }

        [NameInMap("ToParentNodeId")]
        [Validation(Required=false)]
        public string ToParentNodeId { get; set; }

        [NameInMap("ToPrevNodeId")]
        [Validation(Required=false)]
        public string ToPrevNodeId { get; set; }

    }

}
