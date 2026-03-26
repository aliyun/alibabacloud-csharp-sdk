// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class LineageRelation : TeaModel {
        /// <summary>
        /// <para>DestEntityQualifiedName</para>
        /// </summary>
        [NameInMap("DestEntityQualifiedName")]
        [Validation(Required=false)]
        public string DestEntityQualifiedName { get; set; }

        /// <summary>
        /// <para>RelationshipGuid</para>
        /// </summary>
        [NameInMap("RelationshipGuid")]
        [Validation(Required=false)]
        public string RelationshipGuid { get; set; }

        /// <summary>
        /// <para>SrcEntityQualifiedName</para>
        /// </summary>
        [NameInMap("SrcEntityQualifiedName")]
        [Validation(Required=false)]
        public string SrcEntityQualifiedName { get; set; }

    }

}
