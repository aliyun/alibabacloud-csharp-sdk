// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListDashboardResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListDashboardResponseBodyResult Result { get; set; }
        public class ListDashboardResponseBodyResult : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListDashboardResponseBodyResultList> List { get; set; }
            public class ListDashboardResponseBodyResultList : TeaModel {
                public float? UvCtr { get; set; }
                public long? BizDate { get; set; }
                public long? ActiveItem { get; set; }
                public float? PerUvBhv { get; set; }
                public long? Uv { get; set; }
                public float? PerUvClick { get; set; }
                public long? Pv { get; set; }
                public float? Ctr { get; set; }
                public string SceneId { get; set; }
                public string TraceId { get; set; }
                public long? Click { get; set; }
                public long? ClickUser { get; set; }
            }
            [NameInMap("Num")]
            [Validation(Required=false)]
            public int? Num { get; set; }
        };

    }

}
