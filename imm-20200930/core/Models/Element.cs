// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Element : TeaModel {
        [NameInMap("ElementContents")]
        [Validation(Required=false)]
        public List<ElementContent> ElementContents { get; set; }

        [NameInMap("ElementRelations")]
        [Validation(Required=false)]
        public List<ElementRelation> ElementRelations { get; set; }

        [NameInMap("ElementType")]
        [Validation(Required=false)]
        public string ElementType { get; set; }

        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        [NameInMap("SemanticSimilarity")]
        [Validation(Required=false)]
        public float? SemanticSimilarity { get; set; }

    }

}
