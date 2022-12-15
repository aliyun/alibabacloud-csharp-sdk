// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_oxs_cross20200701.Models
{
    public class QuerySDKInstancesRequest : TeaModel {
        [NameInMap("CodeList")]
        [Validation(Required=false)]
        public string CodeList { get; set; }

        [NameInMap("CreatedAfterDate")]
        [Validation(Required=false)]
        public string CreatedAfterDate { get; set; }

        [NameInMap("CreatedBeforeDate")]
        [Validation(Required=false)]
        public string CreatedBeforeDate { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Pk")]
        [Validation(Required=false)]
        public string Pk { get; set; }

    }

}
