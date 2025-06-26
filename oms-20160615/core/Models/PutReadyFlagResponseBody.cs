// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oms20160615.Models
{
    public class PutReadyFlagResponseBody : TeaModel {
        [NameInMap("ApiType")]
        [Validation(Required=false)]
        public string ApiType { get; set; }

        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("DomainCode")]
        [Validation(Required=false)]
        public string DomainCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SourceRequestId")]
        [Validation(Required=false)]
        public string SourceRequestId { get; set; }

    }

}
