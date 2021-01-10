// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkeLinktCreatestatusandupdatetoworkflowRequest : TeaModel {
        [NameInMap("FormJsonStr")]
        [Validation(Required=false)]
        public string FormJsonStr { get; set; }

        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

        [NameInMap("WorkflowStatusId")]
        [Validation(Required=false)]
        public string WorkflowStatusId { get; set; }

    }

}
