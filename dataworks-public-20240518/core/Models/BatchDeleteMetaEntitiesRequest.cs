// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class BatchDeleteMetaEntitiesRequest : TeaModel {
        /// <summary>
        /// <para>The list of entity IDs to delete. A maximum of 10 IDs are supported. All entities in the same batch must be of the same entityType.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<string> Ids { get; set; }

    }

}
