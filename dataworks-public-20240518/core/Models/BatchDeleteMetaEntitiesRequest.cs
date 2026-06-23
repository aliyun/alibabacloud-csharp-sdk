// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class BatchDeleteMetaEntitiesRequest : TeaModel {
        /// <summary>
        /// <para>An array of IDs for the meta entities to delete. You can specify up to 10 IDs in a single request. All entities in the batch must have the same EntityType.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<string> Ids { get; set; }

    }

}
