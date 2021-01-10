// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsResourceGroupByNameResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Resopnse")]
        [Validation(Required=false)]
        public QueryRmsResourceGroupByNameResponseBodyResopnse Resopnse { get; set; }
        public class QueryRmsResourceGroupByNameResponseBodyResopnse : TeaModel {
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public string Layer { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryRmsResourceGroupByNameResponseBodyResopnseData Data { get; set; }
            public class QueryRmsResourceGroupByNameResponseBodyResopnseData : TeaModel {
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("OriginType")]
                [Validation(Required=false)]
                public string OriginType { get; set; }

                [NameInMap("ResType")]
                [Validation(Required=false)]
                public string ResType { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("UtcCreated")]
                [Validation(Required=false)]
                public string UtcCreated { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }

                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                [NameInMap("EntryRes")]
                [Validation(Required=false)]
                public List<QueryRmsResourceGroupByNameResponseBodyResopnseDataEntryRes> EntryRes { get; set; }
                public class QueryRmsResourceGroupByNameResponseBodyResopnseDataEntryRes : TeaModel {
                    [NameInMap("ResId")]
                    [Validation(Required=false)]
                    public string ResId { get; set; }

                    [NameInMap("ResName")]
                    [Validation(Required=false)]
                    public string ResName { get; set; }

                }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<QueryRmsResourceGroupByNameResponseBodyResopnseDataLabels> Labels { get; set; }
                public class QueryRmsResourceGroupByNameResponseBodyResopnseDataLabels : TeaModel {
                    [NameInMap("ResId")]
                    [Validation(Required=false)]
                    public string ResId { get; set; }

                    [NameInMap("ResName")]
                    [Validation(Required=false)]
                    public string ResName { get; set; }

                }

            }
        };

    }

}
