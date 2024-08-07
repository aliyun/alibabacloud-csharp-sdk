// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryCopilotEmbedConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryCopilotEmbedConfigResponseBodyResult> Result { get; set; }
        public class QueryCopilotEmbedConfigResponseBodyResult : TeaModel {
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            [NameInMap("CopilotId")]
            [Validation(Required=false)]
            public string CopilotId { get; set; }

            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            [NameInMap("DataRange")]
            [Validation(Required=false)]
            public QueryCopilotEmbedConfigResponseBodyResultDataRange DataRange { get; set; }
            public class QueryCopilotEmbedConfigResponseBodyResultDataRange : TeaModel {
                [NameInMap("AllCube")]
                [Validation(Required=false)]
                public bool? AllCube { get; set; }

                [NameInMap("AllTheme")]
                [Validation(Required=false)]
                public bool? AllTheme { get; set; }

                [NameInMap("LlmCubes")]
                [Validation(Required=false)]
                public List<string> LlmCubes { get; set; }

                [NameInMap("Themes")]
                [Validation(Required=false)]
                public List<string> Themes { get; set; }

            }

            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
