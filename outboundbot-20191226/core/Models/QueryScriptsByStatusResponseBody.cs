// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class QueryScriptsByStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Scripts")]
        [Validation(Required=false)]
        public QueryScriptsByStatusResponseBodyScripts Scripts { get; set; }
        public class QueryScriptsByStatusResponseBodyScripts : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryScriptsByStatusResponseBodyScriptsList> List { get; set; }
            public class QueryScriptsByStatusResponseBodyScriptsList : TeaModel {
                [NameInMap("AppliedVersion")]
                [Validation(Required=false)]
                public string AppliedVersion { get; set; }

                [NameInMap("DebugStatus")]
                [Validation(Required=false)]
                public string DebugStatus { get; set; }

                [NameInMap("DebugVersion")]
                [Validation(Required=false)]
                public string DebugVersion { get; set; }

                [NameInMap("Industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                [NameInMap("IsDebugDrafted")]
                [Validation(Required=false)]
                public bool? IsDebugDrafted { get; set; }

                [NameInMap("IsDrafted")]
                [Validation(Required=false)]
                public bool? IsDrafted { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("ScriptDescription")]
                [Validation(Required=false)]
                public string ScriptDescription { get; set; }

                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                [NameInMap("ScriptName")]
                [Validation(Required=false)]
                public string ScriptName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
