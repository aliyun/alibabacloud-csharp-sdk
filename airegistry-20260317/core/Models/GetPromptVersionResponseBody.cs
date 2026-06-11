// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class GetPromptVersionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPromptVersionResponseBodyData Data { get; set; }
        public class GetPromptVersionResponseBodyData : TeaModel {
            [NameInMap("CommitMsg")]
            [Validation(Required=false)]
            public string CommitMsg { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            [NameInMap("PromptKey")]
            [Validation(Required=false)]
            public string PromptKey { get; set; }

            [NameInMap("SrcUser")]
            [Validation(Required=false)]
            public string SrcUser { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<GetPromptVersionResponseBodyDataVariables> Variables { get; set; }
            public class GetPromptVersionResponseBodyDataVariables : TeaModel {
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
