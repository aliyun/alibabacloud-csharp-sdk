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
        /// <para>DataChannel</para>
        /// </summary>
        [NameInMap("DataChannel")]
        [Validation(Required=false)]
        public string DataChannel { get; set; }

        /// <summary>
        /// <para>RelationshipGuid</para>
        /// </summary>
        [NameInMap("RelationshipGuid")]
        [Validation(Required=false)]
        public string RelationshipGuid { get; set; }

        /// <summary>
        /// <para>RelationshipType</para>
        /// </summary>
        [NameInMap("RelationshipType")]
        [Validation(Required=false)]
        public string RelationshipType { get; set; }

    }

}
