// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RelationshipVO : TeaModel {
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attributes { get; set; }

        [NameInMap("RelationshipGuid")]
        [Validation(Required=false)]
        public string RelationshipGuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sql</para>
        /// </summary>
        [NameInMap("RelationshipType")]
        [Validation(Required=false)]
        public string RelationshipType { get; set; }

    }

}
