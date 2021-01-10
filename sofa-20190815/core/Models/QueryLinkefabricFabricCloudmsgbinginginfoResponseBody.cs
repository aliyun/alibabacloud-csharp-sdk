// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkefabricFabricCloudmsgbinginginfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryLinkefabricFabricCloudmsgbinginginfoResponseBodyData> Data { get; set; }
        public class QueryLinkefabricFabricCloudmsgbinginginfoResponseBodyData : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Eventcode")]
            [Validation(Required=false)]
            public string Eventcode { get; set; }

            [NameInMap("ExchangeType")]
            [Validation(Required=false)]
            public string ExchangeType { get; set; }

            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Persistence")]
            [Validation(Required=false)]
            public bool? Persistence { get; set; }

            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

            [NameInMap("WorkspaceGroup")]
            [Validation(Required=false)]
            public string WorkspaceGroup { get; set; }

            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

            [NameInMap("ZoneMode")]
            [Validation(Required=false)]
            public string ZoneMode { get; set; }

        }

    }

}
