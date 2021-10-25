// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCommandsResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Commands")]
        [Validation(Required=false)]
        public ListCommandsResponseBodyCommands Commands { get; set; }
        public class ListCommandsResponseBodyCommands : TeaModel {
            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<ListCommandsResponseBodyCommandsCommand> Command { get; set; }
            public class ListCommandsResponseBodyCommandsCommand : TeaModel {
                public string Timeout { get; set; }
                public string CommandId { get; set; }
                public string WorkingDir { get; set; }
                public string CommandContent { get; set; }
            }
        };

    }

}
