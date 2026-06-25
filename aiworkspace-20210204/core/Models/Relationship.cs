// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Relationship : TeaModel {
        /// <summary>
        /// <para>A collection of key-value pairs providing additional details about the relationship.</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// <para>The channel or system through which the relationship is established.</para>
        /// </summary>
        [NameInMap("DataChannel")]
        [Validation(Required=false)]
        public string DataChannel { get; set; }

        /// <summary>
        /// <para>The globally unique identifier (GUID) for the relationship.</para>
        /// </summary>
        [NameInMap("RelationshipGuid")]
        [Validation(Required=false)]
        public string RelationshipGuid { get; set; }

        /// <summary>
        /// <para>Specifies the type of relationship.</para>
        /// </summary>
        [NameInMap("RelationshipType")]
        [Validation(Required=false)]
        public string RelationshipType { get; set; }

    }

}
