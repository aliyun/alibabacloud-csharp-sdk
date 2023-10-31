// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class QueryEnterpriseDataListShrinkRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("DataName")]
        [Validation(Required=false)]
        public string DataName { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("StoreType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
