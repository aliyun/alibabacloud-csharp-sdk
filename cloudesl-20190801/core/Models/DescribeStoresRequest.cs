// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class DescribeStoresRequest : TeaModel {
        [NameInMap("Brand")]
        [Validation(Required=false)]
        public string Brand { get; set; }

        [NameInMap("CompanyId")]
        [Validation(Required=false)]
        public string CompanyId { get; set; }

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

        [NameInMap("ToDate")]
        [Validation(Required=false)]
        public string ToDate { get; set; }

    }

}
