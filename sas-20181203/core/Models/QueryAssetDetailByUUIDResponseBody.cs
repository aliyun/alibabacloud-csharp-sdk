// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryAssetDetailByUUIDResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAssetDetailByUUIDResponseBodyData> Data { get; set; }
        public class QueryAssetDetailByUUIDResponseBodyData : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            [NameInMap("Bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            [NameInMap("Bind")]
            [Validation(Required=false)]
            public bool? Bind { get; set; }

            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("Eip")]
            [Validation(Required=false)]
            public string Eip { get; set; }

            [NameInMap("Flag")]
            [Validation(Required=false)]
            public int? Flag { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("MachineInstanceId")]
            [Validation(Required=false)]
            public string MachineInstanceId { get; set; }

            [NameInMap("MachineIp")]
            [Validation(Required=false)]
            public string MachineIp { get; set; }

            [NameInMap("MachineIpType")]
            [Validation(Required=false)]
            public string MachineIpType { get; set; }

            [NameInMap("MachineName")]
            [Validation(Required=false)]
            public string MachineName { get; set; }

            [NameInMap("MachineRegion")]
            [Validation(Required=false)]
            public string MachineRegion { get; set; }

            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            [NameInMap("OsName")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TimeCost")]
        [Validation(Required=false)]
        public long? TimeCost { get; set; }

    }

}
