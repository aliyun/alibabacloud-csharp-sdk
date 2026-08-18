// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class BatchCreateMetaEntitiesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of entities. A maximum of five entities are supported. All entities in the same batch must have the same entityType.</para>
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
