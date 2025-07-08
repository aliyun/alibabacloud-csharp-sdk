// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySlsStatusNewResponseBody : TeaModel {
        [NameInMap("AuthorizeStatus")]
        [Validation(Required=false)]
        public bool? AuthorizeStatus { get; set; }

        [NameInMap("OpenStatus")]
        [Validation(Required=false)]
        public bool? OpenStatus { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SaveTime")]
        [Validation(Required=false)]
        public int? SaveTime { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
