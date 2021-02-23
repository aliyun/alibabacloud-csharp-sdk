// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class GetFlowResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        [NameInMap("FlowDescription")]
        [Validation(Required=false)]
        public string FlowDescription { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("CurrentVersionId")]
        [Validation(Required=false)]
        public int? CurrentVersionId { get; set; }

        [NameInMap("FlowStatus")]
        [Validation(Required=false)]
        public string FlowStatus { get; set; }

        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("FlowSource")]
        [Validation(Required=false)]
        public string FlowSource { get; set; }

        [NameInMap("FlowEditMode")]
        [Validation(Required=false)]
        public string FlowEditMode { get; set; }

    }

}
