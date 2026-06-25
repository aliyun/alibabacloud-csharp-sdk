// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class LineageRelation : TeaModel {
        /// <summary>
        /// <para>The fully qualified name of the target entity in the relationship.</para>
        /// </summary>
        [NameInMap("DestEntityQualifiedName")]
        [Validation(Required=false)]
        public string DestEntityQualifiedName { get; set; }

        /// <summary>
        /// <para>The system-assigned unique identifier (GUID) for the relationship.</para>
        /// </summary>
        [NameInMap("RelationshipGuid")]
        [Validation(Required=false)]
        public string RelationshipGuid { get; set; }

        /// <summary>
        /// <para>The fully qualified name of the source entity in the relationship.</para>
        /// </summary>
        [NameInMap("SrcEntityQualifiedName")]
        [Validation(Required=false)]
        public string SrcEntityQualifiedName { get; set; }

    }

}
