// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ListDataSourceAttributeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DbList")]
        [Validation(Required=false)]
        public List<ListDataSourceAttributeResponseBodyDbList> DbList { get; set; }
        public class ListDataSourceAttributeResponseBodyDbList : TeaModel {
            [NameInMap("ResultAuditMode")]
            [Validation(Required=false)]
            public string ResultAuditMode { get; set; }

            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            [NameInMap("ResultAuditMaxSize")]
            [Validation(Required=false)]
            public int? ResultAuditMaxSize { get; set; }

            [NameInMap("AuditMode")]
            [Validation(Required=false)]
            public string AuditMode { get; set; }

            [NameInMap("ResultAuditMaxLine")]
            [Validation(Required=false)]
            public int? ResultAuditMaxLine { get; set; }

        }

    }

}
