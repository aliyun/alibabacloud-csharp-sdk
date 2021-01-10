// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryTSJobItemsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryTSJobItemsResponseBodyData> Data { get; set; }
        public class QueryTSJobItemsResponseBodyData : TeaModel {
            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            [NameInMap("Des")]
            [Validation(Required=false)]
            public string Des { get; set; }

            [NameInMap("FailHandleStrategy")]
            [Validation(Required=false)]
            public string FailHandleStrategy { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InvokeType")]
            [Validation(Required=false)]
            public string InvokeType { get; set; }

            [NameInMap("JobItemId")]
            [Validation(Required=false)]
            public long? JobItemId { get; set; }

            [NameInMap("MisfireStrategy")]
            [Validation(Required=false)]
            public string MisfireStrategy { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RouteStrategy")]
            [Validation(Required=false)]
            public string RouteStrategy { get; set; }

            [NameInMap("SofarouterGroup")]
            [Validation(Required=false)]
            public string SofarouterGroup { get; set; }

            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public string Timeout { get; set; }

            [NameInMap("TimeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

            [NameInMap("TriggerMode")]
            [Validation(Required=false)]
            public string TriggerMode { get; set; }

            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("JobZone")]
            [Validation(Required=false)]
            public string JobZone { get; set; }

            [NameInMap("JobRunMode")]
            [Validation(Required=false)]
            public string JobRunMode { get; set; }

            [NameInMap("CountOfClient")]
            [Validation(Required=false)]
            public long? CountOfClient { get; set; }

            [NameInMap("TotalZone")]
            [Validation(Required=false)]
            public string TotalZone { get; set; }

            [NameInMap("CountOfActiveZone")]
            [Validation(Required=false)]
            public bool? CountOfActiveZone { get; set; }

            [NameInMap("ExtensionInfo")]
            [Validation(Required=false)]
            public string ExtensionInfo { get; set; }

            [NameInMap("Handlers")]
            [Validation(Required=false)]
            public List<string> Handlers { get; set; }

        }

    }

}
