// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetMultipartFileUploadInfosResponseBody : TeaModel {
        [NameInMap("multipartHeaderSignatureInfos")]
        [Validation(Required=false)]
        public List<GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos> MultipartHeaderSignatureInfos { get; set; }
        public class GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos : TeaModel {
            [NameInMap("HeaderSignatureInfo")]
            [Validation(Required=false)]
            public GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo HeaderSignatureInfo { get; set; }
            public class GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo : TeaModel {
                [NameInMap("ExpirationSeconds")]
                [Validation(Required=false)]
                public int? ExpirationSeconds { get; set; }

                [NameInMap("Headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                [NameInMap("InternalResourceUrls")]
                [Validation(Required=false)]
                public List<string> InternalResourceUrls { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ResourceUrls")]
                [Validation(Required=false)]
                public List<string> ResourceUrls { get; set; }

            }

            [NameInMap("PartNumber")]
            [Validation(Required=false)]
            public int? PartNumber { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
