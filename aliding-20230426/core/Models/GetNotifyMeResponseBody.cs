// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetNotifyMeResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetNotifyMeResponseBodyData> Data { get; set; }
        public class GetNotifyMeResponseBodyData : TeaModel {
            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("CreateTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("FormInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            [NameInMap("InstStatus")]
            [Validation(Required=false)]
            public string InstStatus { get; set; }

            [NameInMap("MobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }

            [NameInMap("ModifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
