// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAgentInstallStatusResponseBody : TeaModel {
        [NameInMap("AegisClientInvokeStatusResponseList")]
        [Validation(Required=false)]
        public List<DescribeAgentInstallStatusResponseBodyAegisClientInvokeStatusResponseList> AegisClientInvokeStatusResponseList { get; set; }
        public class DescribeAgentInstallStatusResponseBodyAegisClientInvokeStatusResponseList : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("ResuleCode")]
            [Validation(Required=false)]
            public string ResuleCode { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
