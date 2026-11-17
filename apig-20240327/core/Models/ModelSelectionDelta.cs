// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ModelSelectionDelta : TeaModel {
        /// <summary>
        /// <para>The actual source model IDs to add to the unique ModelAPI. Already selected IDs must not be added again.</para>
        /// </summary>
        [NameInMap("addModelCardIds")]
        [Validation(Required=false)]
        public List<string> AddModelCardIds { get; set; }

        /// <summary>
        /// <para>The actual source model IDs to remove from the unique ModelAPI. This operation does not delete models in the source. You cannot clear the API or remove backup models that are still referenced by other entry points.</para>
        /// </summary>
        [NameInMap("removeModelCardIds")]
        [Validation(Required=false)]
        public List<string> RemoveModelCardIds { get; set; }

    }

}
