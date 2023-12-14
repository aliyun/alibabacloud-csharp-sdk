// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class UpdateEnterpriseDataInfoRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        [NameInMap("DataName")]
        [Validation(Required=false)]
        public string DataName { get; set; }

        [NameInMap("FilePreviewLink")]
        [Validation(Required=false)]
        public string FilePreviewLink { get; set; }

    }

}
