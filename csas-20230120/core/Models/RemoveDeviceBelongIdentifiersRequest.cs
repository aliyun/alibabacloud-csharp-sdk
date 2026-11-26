// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class RemoveDeviceBelongIdentifiersRequest : TeaModel {
        /// <summary>
        /// <para>The list of identifier record IDs to remove. You can specify 1 to 1,000 IDs per batch. All IDs must exist and belong to the current tenant. Otherwise, an InvalidParameter error is returned and no records are deleted.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IdentifierIds")]
        [Validation(Required=false)]
        public List<string> IdentifierIds { get; set; }

    }

}
