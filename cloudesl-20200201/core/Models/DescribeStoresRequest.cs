// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20200201.Models
{
    public class DescribeStoresRequest : TeaModel {
        [NameInMap("ExtraParams")]
        [Validation(Required=false)]
        public string ExtraParams { get; set; }

        [NameInMap("FromDate")]
        [Validation(Required=false)]
        public string FromDate { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

        [NameInMap("StoreName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        [NameInMap("ToDate")]
        [Validation(Required=false)]
        public string ToDate { get; set; }

        [NameInMap("UserStoreCode")]
        [Validation(Required=false)]
        public string UserStoreCode { get; set; }

    }

}
