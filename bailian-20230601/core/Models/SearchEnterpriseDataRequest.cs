// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class SearchEnterpriseDataRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("DataIdList")]
        [Validation(Required=false)]
        public List<string> DataIdList { get; set; }

        [NameInMap("EnableRank")]
        [Validation(Required=false)]
        public bool? EnableRank { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public long? StoreId { get; set; }

        [NameInMap("TagIdList")]
        [Validation(Required=false)]
        public List<long?> TagIdList { get; set; }

    }

}
