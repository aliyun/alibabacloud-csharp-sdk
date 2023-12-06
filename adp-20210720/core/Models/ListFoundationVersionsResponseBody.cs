// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListFoundationVersionsResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListFoundationVersionsResponseBodyData Data { get; set; }
        public class ListFoundationVersionsResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<FoundationVersion> List { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
