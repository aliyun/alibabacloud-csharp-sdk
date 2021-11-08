// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class DescribeCoreWordResponseBody : TeaModel {
        [NameInMap("CoreWordCode")]
        [Validation(Required=false)]
        public string CoreWordCode { get; set; }

        [NameInMap("CoreWordName")]
        [Validation(Required=false)]
        public string CoreWordName { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Synonyms")]
        [Validation(Required=false)]
        public List<string> Synonyms { get; set; }

    }

}
