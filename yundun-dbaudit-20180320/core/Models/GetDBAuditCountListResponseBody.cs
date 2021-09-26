// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetDBAuditCountListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DbList")]
        [Validation(Required=false)]
        public List<GetDBAuditCountListResponseBodyDbList> DbList { get; set; }
        public class GetDBAuditCountListResponseBodyDbList : TeaModel {
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("DbType")]
            [Validation(Required=false)]
            public int? DbType { get; set; }

            [NameInMap("SqlCount")]
            [Validation(Required=false)]
            public long? SqlCount { get; set; }

            [NameInMap("DbTypeName")]
            [Validation(Required=false)]
            public string DbTypeName { get; set; }

            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            [NameInMap("DbVersionName")]
            [Validation(Required=false)]
            public string DbVersionName { get; set; }

            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public int? DbVersion { get; set; }

            [NameInMap("DbAddresses")]
            [Validation(Required=false)]
            public List<string> DbAddresses { get; set; }

        }

    }

}
