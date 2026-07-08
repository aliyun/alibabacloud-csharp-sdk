// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class WritingStyleTemplateDefine : TeaModel {
        [NameInMap("Example")]
        [Validation(Required=false)]
        public List<WritingStyleTemplateDefineExample> Example { get; set; }
        public class WritingStyleTemplateDefineExample : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<WritingStyleTemplateField> Fields { get; set; }

    }

}
