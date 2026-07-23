// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SourceFeiShuDocsParameters : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppSecret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        [NameInMap("KnowledgeSpaceName")]
        [Validation(Required=false)]
        public string KnowledgeSpaceName { get; set; }

        [NameInMap("LoadMode")]
        [Validation(Required=false)]
        public string LoadMode { get; set; }

    }

}
