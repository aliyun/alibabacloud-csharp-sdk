// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class ListFlowsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("Flows")]
        [Validation(Required=true)]
        public List<ListFlowsResponseFlows> Flows { get; set; }
        public class ListFlowsResponseFlows : TeaModel {
            [NameInMap("FlowId")]
            [Validation(Required=true)]
            public string FlowId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=true)]
            public string RegionId { get; set; }

            [NameInMap("FlowName")]
            [Validation(Required=true)]
            public string FlowName { get; set; }

            [NameInMap("FlowDescription")]
            [Validation(Required=true)]
            public string FlowDescription { get; set; }

            [NameInMap("VersionId")]
            [Validation(Required=true)]
            public int? VersionId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=true)]
            public string UpdateTime { get; set; }

            [NameInMap("FlowStatus")]
            [Validation(Required=true)]
            public string FlowStatus { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=true)]
            public string TemplateId { get; set; }

            [NameInMap("FlowSource")]
            [Validation(Required=true)]
            public string FlowSource { get; set; }

            [NameInMap("FlowEditMode")]
            [Validation(Required=true)]
            public string FlowEditMode { get; set; }

        }

    }

}
