// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class ListAppsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAppsResponseBodyData Data { get; set; }
        public class ListAppsResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListAppsResponseBodyDataItems> Items { get; set; }
            public class ListAppsResponseBodyDataItems : TeaModel {
                public string DepartmentName { get; set; }
                public string PackageName { get; set; }
                public string CreatedAt { get; set; }
                public string DepartmentId { get; set; }
                public bool? Disabled { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
            }
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
