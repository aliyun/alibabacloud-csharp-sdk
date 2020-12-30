// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTransferInListResponseBody : TeaModel {
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTransferInListResponseBodyData Data { get; set; }
        public class QueryTransferInListResponseBodyData : TeaModel {
            [NameInMap("TransferInInfo")]
            [Validation(Required=false)]
            public List<QueryTransferInListResponseBodyDataTransferInInfo> TransferInInfo { get; set; }
            public class QueryTransferInListResponseBodyDataTransferInInfo : TeaModel {
                public int? Status { get; set; }
                public string UserId { get; set; }
                public string ModificationDate { get; set; }
                public long? TransferAuthorizationCodeSubmissionDateLong { get; set; }
                public long? SubmissionDateLong { get; set; }
                public string ResultCode { get; set; }
                public bool? NeedMailCheck { get; set; }
                public long? ModificationDateLong { get; set; }
                public string InstanceId { get; set; }
                public string DomainName { get; set; }
                public int? ProgressBarType { get; set; }
                public string ResultMsg { get; set; }
                public long? ResultDateLong { get; set; }
                public string ExpirationDate { get; set; }
                public string Email { get; set; }
                public bool? WhoisMailStatus { get; set; }
                public string TransferAuthorizationCodeSubmissionDate { get; set; }
                public string SubmissionDate { get; set; }
                public long? ExpirationDateLong { get; set; }
                public string SimpleTransferInStatus { get; set; }
                public string ResultDate { get; set; }
            }
        };

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

    }

}
