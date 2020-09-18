// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class GetFlowResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

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

        [NameInMap("CreateTime")]
        [Validation(Required=true)]
        public string CreateTime { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=true)]
        public string UpdateTime { get; set; }

        [NameInMap("CurrentVersionId")]
        [Validation(Required=true)]
        public int? CurrentVersionId { get; set; }

        [NameInMap("FlowStatus")]
        [Validation(Required=true)]
        public string FlowStatus { get; set; }

        [NameInMap("Definition")]
        [Validation(Required=true)]
        public string Definition { get; set; }

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
