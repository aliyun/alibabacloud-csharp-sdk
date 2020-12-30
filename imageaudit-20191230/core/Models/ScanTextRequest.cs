// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageaudit20191230.Models
{
    public class ScanTextRequest : TeaModel {
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ScanTextRequestTasks> Tasks { get; set; }
        public class ScanTextRequestTasks : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<ScanTextRequestLabels> Labels { get; set; }
        public class ScanTextRequestLabels : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

        }

    }

}
