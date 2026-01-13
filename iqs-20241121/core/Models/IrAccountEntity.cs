// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class IrAccountEntity : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("accountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("accountStatus")]
        [Validation(Required=false)]
        public string AccountStatus { get; set; }

        [NameInMap("adjustedNormalQps")]
        [Validation(Required=false)]
        public int? AdjustedNormalQps { get; set; }

        [NameInMap("configuration")]
        [Validation(Required=false)]
        public string Configuration { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("isDeleted")]
        [Validation(Required=false)]
        public int? IsDeleted { get; set; }

        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("quarkKey")]
        [Validation(Required=false)]
        public string QuarkKey { get; set; }

        [NameInMap("quarkOsr")]
        [Validation(Required=false)]
        public string QuarkOsr { get; set; }

        [NameInMap("quarkUsername")]
        [Validation(Required=false)]
        public string QuarkUsername { get; set; }

        [NameInMap("searchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        [NameInMap("testQps")]
        [Validation(Required=false)]
        public int? TestQps { get; set; }

        [NameInMap("testQueryPerDay")]
        [Validation(Required=false)]
        public int? TestQueryPerDay { get; set; }

        [NameInMap("testStartTime")]
        [Validation(Required=false)]
        public string TestStartTime { get; set; }

    }

}
