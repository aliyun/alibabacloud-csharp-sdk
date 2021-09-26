// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ListDataSourcesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DbList")]
        [Validation(Required=false)]
        public List<ListDataSourcesResponseBodyDbList> DbList { get; set; }
        public class ListDataSourcesResponseBodyDbList : TeaModel {
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DbUsername")]
            [Validation(Required=false)]
            public string DbUsername { get; set; }

            [NameInMap("DbCertificate")]
            [Validation(Required=false)]
            public string DbCertificate { get; set; }

            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public int? DbVersion { get; set; }

            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("DbType")]
            [Validation(Required=false)]
            public int? DbType { get; set; }

            [NameInMap("AuditSwitch")]
            [Validation(Required=false)]
            public int? AuditSwitch { get; set; }

            [NameInMap("DbTypeName")]
            [Validation(Required=false)]
            public string DbTypeName { get; set; }

            [NameInMap("DbVersionName")]
            [Validation(Required=false)]
            public string DbVersionName { get; set; }

            [NameInMap("DbAddresses")]
            [Validation(Required=false)]
            public List<string> DbAddresses { get; set; }

        }

    }

}
