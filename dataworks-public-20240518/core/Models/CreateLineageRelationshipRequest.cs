// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateLineageRelationshipRequest : TeaModel {
        /// <summary>
        /// <para>The destination entity.</para>
        /// </summary>
        [NameInMap("DstEntity")]
        [Validation(Required=false)]
        public LineageEntity DstEntity { get; set; }

        /// <summary>
        /// <para>The source entity.</para>
        /// </summary>
        [NameInMap("SrcEntity")]
        [Validation(Required=false)]
        public LineageEntity SrcEntity { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public LineageTask Task { get; set; }

    }

}
