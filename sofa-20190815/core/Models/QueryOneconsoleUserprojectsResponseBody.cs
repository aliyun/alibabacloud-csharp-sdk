// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryOneconsoleUserprojectsResponseBody : TeaModel {
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
        public List<QueryOneconsoleUserprojectsResponseBodyData> Data { get; set; }
        public class QueryOneconsoleUserprojectsResponseBodyData : TeaModel {
            [NameInMap("BusinessOwnerId")]
            [Validation(Required=false)]
            public string BusinessOwnerId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("MasterId")]
            [Validation(Required=false)]
            public string MasterId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("UniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }

        }

    }

}
