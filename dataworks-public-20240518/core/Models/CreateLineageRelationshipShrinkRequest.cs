// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateLineageRelationshipShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The destination entity.</para>
        /// </summary>
        [NameInMap("DstEntity")]
        [Validation(Required=false)]
        public string DstEntityShrink { get; set; }

        /// <summary>
        /// <para>The source entity.</para>
        /// </summary>
        [NameInMap("SrcEntity")]
        [Validation(Required=false)]
        public string SrcEntityShrink { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public string TaskShrink { get; set; }

    }

}
