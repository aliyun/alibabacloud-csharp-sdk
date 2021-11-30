// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class ListCACertificateLogResponseBody : TeaModel {
        [NameInMap("LogList")]
        [Validation(Required=false)]
        public List<ListCACertificateLogResponseBodyLogList> LogList { get; set; }
        public class ListCACertificateLogResponseBodyLogList : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
