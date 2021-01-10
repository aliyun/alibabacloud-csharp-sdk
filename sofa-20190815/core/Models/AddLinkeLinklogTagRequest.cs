// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeLinklogTagRequest : TeaModel {
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public long? KnowledgeId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RelationId")]
        [Validation(Required=false)]
        public long? RelationId { get; set; }

        [NameInMap("TagId")]
        [Validation(Required=false)]
        public long? TagId { get; set; }

    }

}
