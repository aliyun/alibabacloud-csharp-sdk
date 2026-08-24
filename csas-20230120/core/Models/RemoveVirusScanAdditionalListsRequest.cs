// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class RemoveVirusScanAdditionalListsRequest : TeaModel {
        /// <summary>
        /// <para>The collection of entry IDs to remove. At least one entry ID must be specified.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListIds")]
        [Validation(Required=false)]
        public List<string> ListIds { get; set; }

    }

}
