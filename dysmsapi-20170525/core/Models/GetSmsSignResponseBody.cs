// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetSmsSignResponseBody : TeaModel {
        [NameInMap("ApplyScene")]
        [Validation(Required=false)]
        public string ApplyScene { get; set; }

        [NameInMap("AuditInfo")]
        [Validation(Required=false)]
        public GetSmsSignResponseBodyAuditInfo AuditInfo { get; set; }
        public class GetSmsSignResponseBodyAuditInfo : TeaModel {
            [NameInMap("AuditDate")]
            [Validation(Required=false)]
            public string AuditDate { get; set; }

            [NameInMap("RejectInfo")]
            [Validation(Required=false)]
            public string RejectInfo { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CreateDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        [NameInMap("FileUrlList")]
        [Validation(Required=false)]
        public List<string> FileUrlList { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public long? QualificationId { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SignCode")]
        [Validation(Required=false)]
        public string SignCode { get; set; }

        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        [NameInMap("SignStatus")]
        [Validation(Required=false)]
        public long? SignStatus { get; set; }

        [NameInMap("SignTag")]
        [Validation(Required=false)]
        public string SignTag { get; set; }

        [NameInMap("SignUsage")]
        [Validation(Required=false)]
        public string SignUsage { get; set; }

        [NameInMap("ThirdParty")]
        [Validation(Required=false)]
        public bool? ThirdParty { get; set; }

    }

}
