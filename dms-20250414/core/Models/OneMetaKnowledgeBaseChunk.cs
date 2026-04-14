// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OneMetaKnowledgeBaseChunk : TeaModel {
        [NameInMap("ChunkMtime")]
        [Validation(Required=false)]
        public string ChunkMtime { get; set; }

        [NameInMap("ChunkTitle")]
        [Validation(Required=false)]
        public string ChunkTitle { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
