// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListDSEntityValueResponseBody : TeaModel {
        [NameInMap("EntityValues")]
        [Validation(Required=false)]
        public List<ListDSEntityValueResponseBodyEntityValues> EntityValues { get; set; }
        public class ListDSEntityValueResponseBodyEntityValues : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public long? EntityId { get; set; }

            [NameInMap("EntityValueId")]
            [Validation(Required=false)]
            public long? EntityValueId { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("Synonyms")]
            [Validation(Required=false)]
            public List<string> Synonyms { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
