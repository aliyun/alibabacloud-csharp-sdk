// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class BatchCreateMetaEntitiesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>An entity list. You can create up to five entities in a batch. All entities in the batch must have the same <c>EntityType</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Entities")]
        [Validation(Required=false)]
        public string EntitiesShrink { get; set; }

    }

}
