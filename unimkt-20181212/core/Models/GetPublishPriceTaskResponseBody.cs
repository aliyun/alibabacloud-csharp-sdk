// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class GetPublishPriceTaskResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public Dictionary<string, object> Ext { get; set; }

        [NameInMap("Header")]
        [Validation(Required=false)]
        public GetPublishPriceTaskResponseBodyHeader Header { get; set; }
        public class GetPublishPriceTaskResponseBodyHeader : TeaModel {
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public long? CostTime { get; set; }

            [NameInMap("RpcId")]
            [Validation(Required=false)]
            public string RpcId { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetPublishPriceTaskResponseBodyResult Result { get; set; }
        public class GetPublishPriceTaskResponseBodyResult : TeaModel {
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("Approver")]
            [Validation(Required=false)]
            public string Approver { get; set; }

            [NameInMap("BpmsProcId")]
            [Validation(Required=false)]
            public string BpmsProcId { get; set; }

            [NameInMap("BpmsProcInsId")]
            [Validation(Required=false)]
            public string BpmsProcInsId { get; set; }

            [NameInMap("CatalogPrice")]
            [Validation(Required=false)]
            public long? CatalogPrice { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("DeleteFlag")]
            [Validation(Required=false)]
            public string DeleteFlag { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Remarks")]
            [Validation(Required=false)]
            public string Remarks { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
