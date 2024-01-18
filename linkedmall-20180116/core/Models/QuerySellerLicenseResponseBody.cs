// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QuerySellerLicenseResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QuerySellerLicenseResponseBodyModel Model { get; set; }
        public class QuerySellerLicenseResponseBodyModel : TeaModel {
            [NameInMap("LicenseUrl")]
            [Validation(Required=false)]
            public string LicenseUrl { get; set; }

            [NameInMap("SellerId")]
            [Validation(Required=false)]
            public string SellerId { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
