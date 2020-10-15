// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DistApplicationDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DistInstanceTotalCount")]
        [Validation(Required=true)]
        public int? DistInstanceTotalCount { get; set; }

        [NameInMap("DistResults")]
        [Validation(Required=true)]
        public DistApplicationDataResponseDistResults DistResults { get; set; }
        public class DistApplicationDataResponseDistResults : TeaModel {
            [NameInMap("DistResult")]
            [Validation(Required=true)]
            public List<DistApplicationDataResponseDistResultsDistResult> DistResult { get; set; }
            public class DistApplicationDataResponseDistResultsDistResult : TeaModel {
                public string Version { get; set; }
                public string ResultDescrip { get; set; }
                public int? ResultCode { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("DistInstanceIds")]
        [Validation(Required=true)]
        public DistApplicationDataResponseDistInstanceIds DistInstanceIds { get; set; }
        public class DistApplicationDataResponseDistInstanceIds : TeaModel {
            [NameInMap("DistInstanceId")]
            [Validation(Required=true)]
            public List<string> DistInstanceId { get; set; }
        };

    }

}
