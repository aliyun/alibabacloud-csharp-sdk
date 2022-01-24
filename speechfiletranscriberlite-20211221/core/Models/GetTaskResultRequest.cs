/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SpeechFileTranscriberLite20211221.Models
{
    public class GetTaskResultRequest : TeaModel {
        [NameInMap("Debug")]
        [Validation(Required=false)]
        public bool? Debug { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
