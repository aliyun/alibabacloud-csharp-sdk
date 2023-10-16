// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTrademarkModelListRequest : TeaModel {
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        [NameInMap("OrderIdsStr")]
        [Validation(Required=false)]
        public string OrderIdsStr { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrincipalKey")]
        [Validation(Required=false)]
        public string PrincipalKey { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public string PrincipalName { get; set; }

        [NameInMap("ProduceTypesStr")]
        [Validation(Required=false)]
        public string ProduceTypesStr { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubmitStart")]
        [Validation(Required=false)]
        public string SubmitStart { get; set; }

        [NameInMap("SubmitStatus")]
        [Validation(Required=false)]
        public string SubmitStatus { get; set; }

        [NameInMap("SubmitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

    }

}
