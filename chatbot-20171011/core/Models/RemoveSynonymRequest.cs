// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class RemoveSynonymRequest : TeaModel {
        [NameInMap("CoreWordName")]
        [Validation(Required=false)]
        public string CoreWordName { get; set; }

        [NameInMap("Synonym")]
        [Validation(Required=false)]
        public string Synonym { get; set; }

    }

}
