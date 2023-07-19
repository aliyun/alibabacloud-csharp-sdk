// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeWhitelistTemplateLinkedInstanceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeWhitelistTemplateLinkedInstanceResponseBodyData Data { get; set; }
        public class DescribeWhitelistTemplateLinkedInstanceResponseBodyData : TeaModel {
            [NameInMap("InsName")]
            [Validation(Required=false)]
            public List<string> InsName { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public int? TemplateId { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
