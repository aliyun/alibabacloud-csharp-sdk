// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIpPatentResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcIpPatentResponseBodyData> Data { get; set; }
        public class GetOcIpPatentResponseBodyData : TeaModel {
            [NameInMap("Agency")]
            [Validation(Required=false)]
            public string Agency { get; set; }

            [NameInMap("Agent")]
            [Validation(Required=false)]
            public string Agent { get; set; }

            [NameInMap("Brief")]
            [Validation(Required=false)]
            public string Brief { get; set; }

            [NameInMap("CateNum")]
            [Validation(Required=false)]
            public string CateNum { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("InventorList")]
            [Validation(Required=false)]
            public string InventorList { get; set; }

            [NameInMap("MainClaim")]
            [Validation(Required=false)]
            public string MainClaim { get; set; }

            [NameInMap("PatentName")]
            [Validation(Required=false)]
            public string PatentName { get; set; }

            [NameInMap("PatentStatus")]
            [Validation(Required=false)]
            public string PatentStatus { get; set; }

            [NameInMap("PatentType")]
            [Validation(Required=false)]
            public string PatentType { get; set; }

            [NameInMap("PatenteeList")]
            [Validation(Required=false)]
            public string PatenteeList { get; set; }

            [NameInMap("PrioDate")]
            [Validation(Required=false)]
            public string PrioDate { get; set; }

            [NameInMap("PrioNum")]
            [Validation(Required=false)]
            public string PrioNum { get; set; }

            [NameInMap("PublicDate")]
            [Validation(Required=false)]
            public string PublicDate { get; set; }

            [NameInMap("PublicNum")]
            [Validation(Required=false)]
            public string PublicNum { get; set; }

            [NameInMap("RequestDate")]
            [Validation(Required=false)]
            public string RequestDate { get; set; }

            [NameInMap("RequestNum")]
            [Validation(Required=false)]
            public string RequestNum { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
