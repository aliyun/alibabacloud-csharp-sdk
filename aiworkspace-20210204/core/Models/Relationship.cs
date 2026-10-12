// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Relationship : TeaModel {
        /// <summary>
        /// <para>Attributes</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// <para>The data channel to which the lineage relationship belongs.</para>
        /// </summary>
        [NameInMap("DataChannel")]
        [Validation(Required=false)]
        public string DataChannel { get; set; }

        /// <summary>
        /// <para>The globally unique identifier of the lineage relationship.</para>
        /// </summary>
        [NameInMap("RelationshipGuid")]
        [Validation(Required=false)]
        public string RelationshipGuid { get; set; }

        /// <summary>
        /// <para>The type of the lineage relationship.</para>
        /// </summary>
        [NameInMap("RelationshipType")]
        [Validation(Required=false)]
        public string RelationshipType { get; set; }

    }

}
