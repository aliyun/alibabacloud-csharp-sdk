// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DistApplicationDataResponseBody : TeaModel {
        [NameInMap("DistInstanceIds")]
        [Validation(Required=false)]
        public DistApplicationDataResponseBodyDistInstanceIds DistInstanceIds { get; set; }
        public class DistApplicationDataResponseBodyDistInstanceIds : TeaModel {
            [NameInMap("DistInstanceId")]
            [Validation(Required=false)]
            public List<string> DistInstanceId { get; set; }
        };

        [NameInMap("DistInstanceTotalCount")]
        [Validation(Required=false)]
        public int? DistInstanceTotalCount { get; set; }

        [NameInMap("DistResults")]
        [Validation(Required=false)]
        public DistApplicationDataResponseBodyDistResults DistResults { get; set; }
        public class DistApplicationDataResponseBodyDistResults : TeaModel {
            [NameInMap("DistResult")]
            [Validation(Required=false)]
            public List<DistApplicationDataResponseBodyDistResultsDistResult> DistResult { get; set; }
            public class DistApplicationDataResponseBodyDistResultsDistResult : TeaModel {
                public string Name { get; set; }
                public int? ResultCode { get; set; }
                public string ResultDescrip { get; set; }
                public string Version { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
