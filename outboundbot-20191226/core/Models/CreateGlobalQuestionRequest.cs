// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateGlobalQuestionRequest : TeaModel {
        [NameInMap("Answers")]
        [Validation(Required=false)]
        public string Answers { get; set; }

        [NameInMap("GlobalQuestionName")]
        [Validation(Required=false)]
        public string GlobalQuestionName { get; set; }

        [NameInMap("GlobalQuestionType")]
        [Validation(Required=false)]
        public string GlobalQuestionType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Questions")]
        [Validation(Required=false)]
        public string Questions { get; set; }

        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

    }

}
