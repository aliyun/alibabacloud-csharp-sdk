// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMsTransparentProxyNodeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("StartIndex")]
        [Validation(Required=false)]
        public long? StartIndex { get; set; }

        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryMsTransparentProxyNodeResponseBodyList> List { get; set; }
        public class QueryMsTransparentProxyNodeResponseBodyList : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("MosnVersion")]
            [Validation(Required=false)]
            public string MosnVersion { get; set; }

            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            [NameInMap("RealRun")]
            [Validation(Required=false)]
            public string RealRun { get; set; }

            [NameInMap("SidecarStatus")]
            [Validation(Required=false)]
            public string SidecarStatus { get; set; }

            [NameInMap("TransparentProxySwitch")]
            [Validation(Required=false)]
            public long? TransparentProxySwitch { get; set; }

        }

    }

}
