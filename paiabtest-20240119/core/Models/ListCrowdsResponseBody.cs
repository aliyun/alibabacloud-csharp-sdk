// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIABTest20240119.Models
{
    public class ListCrowdsResponseBody : TeaModel {
        [NameInMap("Crowds")]
        [Validation(Required=false)]
        public List<ListCrowdsResponseBodyCrowds> Crowds { get; set; }
        public class ListCrowdsResponseBodyCrowds : TeaModel {
            [NameInMap("AliyunId")]
            [Validation(Required=false)]
            public string AliyunId { get; set; }

            [NameInMap("CrowdId")]
            [Validation(Required=false)]
            public string CrowdId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifyTime")]
            [Validation(Required=false)]
            public string GmtModifyTime { get; set; }

            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public string Quantity { get; set; }

            [NameInMap("Users")]
            [Validation(Required=false)]
            public string Users { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
