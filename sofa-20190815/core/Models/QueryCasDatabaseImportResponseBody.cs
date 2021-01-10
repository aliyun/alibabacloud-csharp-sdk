// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasDatabaseImportResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCasDatabaseImportResponseBodyData> Data { get; set; }
        public class QueryCasDatabaseImportResponseBodyData : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("IaasId")]
            [Validation(Required=false)]
            public string IaasId { get; set; }

            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            [NameInMap("ImportInfo")]
            [Validation(Required=false)]
            public QueryCasDatabaseImportResponseBodyDataImportInfo ImportInfo { get; set; }
            public class QueryCasDatabaseImportResponseBodyDataImportInfo : TeaModel {
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
