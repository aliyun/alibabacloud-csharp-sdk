// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class SearchPunishRequestResponseBody : TeaModel {
        [NameInMap("Class")]
        [Validation(Required=false)]
        public string Class { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<SearchPunishRequestResponseBodyDataList> DataList { get; set; }
        public class SearchPunishRequestResponseBodyDataList : TeaModel {
            [NameInMap("AntiPunishRespTime")]
            [Validation(Required=false)]
            public string AntiPunishRespTime { get; set; }

            [NameInMap("AntiPunishTime")]
            [Validation(Required=false)]
            public string AntiPunishTime { get; set; }

            [NameInMap("AntiResult")]
            [Validation(Required=false)]
            public string AntiResult { get; set; }

            [NameInMap("AntiStatus")]
            [Validation(Required=false)]
            public string AntiStatus { get; set; }

            [NameInMap("BussinessCode")]
            [Validation(Required=false)]
            public string BussinessCode { get; set; }

            [NameInMap("CaseCode")]
            [Validation(Required=false)]
            public string CaseCode { get; set; }

            [NameInMap("CaseExtendCode")]
            [Validation(Required=false)]
            public string CaseExtendCode { get; set; }

            [NameInMap("CaseSubCode")]
            [Validation(Required=false)]
            public string CaseSubCode { get; set; }

            [NameInMap("Class")]
            [Validation(Required=false)]
            public string Class { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("EventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("ExpectedRemoveTime")]
            [Validation(Required=false)]
            public string ExpectedRemoveTime { get; set; }

            [NameInMap("ExtRequestId")]
            [Validation(Required=false)]
            public string ExtRequestId { get; set; }

            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IpString")]
            [Validation(Required=false)]
            public string IpString { get; set; }

            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("OperatorNum")]
            [Validation(Required=false)]
            public string OperatorNum { get; set; }

            [NameInMap("PunishDomain")]
            [Validation(Required=false)]
            public string PunishDomain { get; set; }

            [NameInMap("PunishIp")]
            [Validation(Required=false)]
            public string PunishIp { get; set; }

            [NameInMap("PunishOfficer")]
            [Validation(Required=false)]
            public string PunishOfficer { get; set; }

            [NameInMap("PunishOfficerNum")]
            [Validation(Required=false)]
            public string PunishOfficerNum { get; set; }

            [NameInMap("PunishRequest")]
            [Validation(Required=false)]
            public string PunishRequest { get; set; }

            [NameInMap("PunishRespTime")]
            [Validation(Required=false)]
            public string PunishRespTime { get; set; }

            [NameInMap("PunishResult")]
            [Validation(Required=false)]
            public string PunishResult { get; set; }

            [NameInMap("PunishStatus")]
            [Validation(Required=false)]
            public string PunishStatus { get; set; }

            [NameInMap("PunishTime")]
            [Validation(Required=false)]
            public string PunishTime { get; set; }

            [NameInMap("PunishUrl")]
            [Validation(Required=false)]
            public string PunishUrl { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("SourceCode")]
            [Validation(Required=false)]
            public string SourceCode { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("ViewCount")]
        [Validation(Required=false)]
        public long? ViewCount { get; set; }

    }

}
