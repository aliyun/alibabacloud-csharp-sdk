// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasLoadbalanceImportResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCasLoadbalanceImportResponseBodyData> Data { get; set; }
        public class QueryCasLoadbalanceImportResponseBodyData : TeaModel {
            [NameInMap("IaasId")]
            [Validation(Required=false)]
            public string IaasId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            [NameInMap("InnerIpAddress")]
            [Validation(Required=false)]
            public List<string> InnerIpAddress { get; set; }

            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public List<string> PublicIpAddress { get; set; }

            [NameInMap("ImportInfo")]
            [Validation(Required=false)]
            public QueryCasLoadbalanceImportResponseBodyDataImportInfo ImportInfo { get; set; }
            public class QueryCasLoadbalanceImportResponseBodyDataImportInfo : TeaModel {
                [NameInMap("ImportedWorkspaceName")]
                [Validation(Required=false)]
                public string ImportedWorkspaceName { get; set; }
                [NameInMap("IsImported")]
                [Validation(Required=false)]
                public bool? IsImported { get; set; }
                [NameInMap("IsUnimportable")]
                [Validation(Required=false)]
                public bool? IsUnimportable { get; set; }
                [NameInMap("UnimportableReason")]
                [Validation(Required=false)]
                public string UnimportableReason { get; set; }
            };

        }

    }

}
