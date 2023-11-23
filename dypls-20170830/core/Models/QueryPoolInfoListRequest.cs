// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class QueryPoolInfoListRequest : TeaModel {
        [NameInMap("IsFuzzyQuery")]
        [Validation(Required=false)]
        public bool? IsFuzzyQuery { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("PoolName")]
        [Validation(Required=false)]
        public string PoolName { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ResType")]
        [Validation(Required=false)]
        public int? ResType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SearchParam")]
        [Validation(Required=false)]
        public string SearchParam { get; set; }

    }

}
