// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class ListCertificateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCertificateResponseBodyData> Data { get; set; }
        public class ListCertificateResponseBodyData : TeaModel {
            [NameInMap("AuthorizationTime")]
            [Validation(Required=false)]
            public long? AuthorizationTime { get; set; }

            [NameInMap("BlockchainNo")]
            [Validation(Required=false)]
            public string BlockchainNo { get; set; }

            [NameInMap("BusinessTypeList")]
            [Validation(Required=false)]
            public List<int?> BusinessTypeList { get; set; }

            [NameInMap("CancelTime")]
            [Validation(Required=false)]
            public long? CancelTime { get; set; }

            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("PhoneNo")]
            [Validation(Required=false)]
            public string PhoneNo { get; set; }

            [NameInMap("SchemeType")]
            [Validation(Required=false)]
            public int? SchemeType { get; set; }

            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
