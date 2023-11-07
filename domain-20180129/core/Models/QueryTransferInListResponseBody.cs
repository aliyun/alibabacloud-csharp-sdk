// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTransferInListResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTransferInListResponseBodyData Data { get; set; }
        public class QueryTransferInListResponseBodyData : TeaModel {
            [NameInMap("TransferInInfo")]
            [Validation(Required=false)]
            public List<QueryTransferInListResponseBodyDataTransferInInfo> TransferInInfo { get; set; }
            public class QueryTransferInListResponseBodyDataTransferInInfo : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("ExpirationDate")]
                [Validation(Required=false)]
                public string ExpirationDate { get; set; }

                [NameInMap("ExpirationDateLong")]
                [Validation(Required=false)]
                public long? ExpirationDateLong { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("ModificationDate")]
                [Validation(Required=false)]
                public string ModificationDate { get; set; }

                [NameInMap("ModificationDateLong")]
                [Validation(Required=false)]
                public long? ModificationDateLong { get; set; }

                [NameInMap("NeedMailCheck")]
                [Validation(Required=false)]
                public bool? NeedMailCheck { get; set; }

                [NameInMap("ProgressBarType")]
                [Validation(Required=false)]
                public int? ProgressBarType { get; set; }

                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public string ResultCode { get; set; }

                [NameInMap("ResultDate")]
                [Validation(Required=false)]
                public string ResultDate { get; set; }

                [NameInMap("ResultDateLong")]
                [Validation(Required=false)]
                public long? ResultDateLong { get; set; }

                [NameInMap("ResultMsg")]
                [Validation(Required=false)]
                public string ResultMsg { get; set; }

                [NameInMap("SimpleTransferInStatus")]
                [Validation(Required=false)]
                public string SimpleTransferInStatus { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("SubmissionDate")]
                [Validation(Required=false)]
                public string SubmissionDate { get; set; }

                [NameInMap("SubmissionDateLong")]
                [Validation(Required=false)]
                public long? SubmissionDateLong { get; set; }

                [NameInMap("TransferAuthorizationCodeSubmissionDate")]
                [Validation(Required=false)]
                public string TransferAuthorizationCodeSubmissionDate { get; set; }

                [NameInMap("TransferAuthorizationCodeSubmissionDateLong")]
                [Validation(Required=false)]
                public long? TransferAuthorizationCodeSubmissionDateLong { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("WhoisMailStatus")]
                [Validation(Required=false)]
                public bool? WhoisMailStatus { get; set; }

            }

        }

        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
