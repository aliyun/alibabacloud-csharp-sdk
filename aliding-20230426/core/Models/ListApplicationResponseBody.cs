// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListApplicationResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListApplicationResponseBodyData> Data { get; set; }
        public class ListApplicationResponseBodyData : TeaModel {
            [NameInMap("AppConfig")]
            [Validation(Required=false)]
            public string AppConfig { get; set; }

            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("ApplicationStatus")]
            [Validation(Required=false)]
            public string ApplicationStatus { get; set; }

            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("Inexistence")]
            [Validation(Required=false)]
            public string Inexistence { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SubCorpId")]
            [Validation(Required=false)]
            public string SubCorpId { get; set; }

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
