// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListDeltaResponseBody : TeaModel {
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        [NameInMap("has_more")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListDeltaResponseBodyItems> Items { get; set; }
        public class ListDeltaResponseBodyItems : TeaModel {
            [NameInMap("file")]
            [Validation(Required=false)]
            public File File { get; set; }

            [NameInMap("file_id")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

        }

    }

}
