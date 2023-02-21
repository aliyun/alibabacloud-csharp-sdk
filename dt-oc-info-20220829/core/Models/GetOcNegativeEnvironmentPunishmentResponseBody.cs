// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcNegativeEnvironmentPunishmentResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcNegativeEnvironmentPunishmentResponseBodyData> Data { get; set; }
        public class GetOcNegativeEnvironmentPunishmentResponseBodyData : TeaModel {
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("ExecStatus")]
            [Validation(Required=false)]
            public string ExecStatus { get; set; }

            [NameInMap("PunishBasis")]
            [Validation(Required=false)]
            public string PunishBasis { get; set; }

            [NameInMap("PunishContent")]
            [Validation(Required=false)]
            public string PunishContent { get; set; }

            [NameInMap("PunishDate")]
            [Validation(Required=false)]
            public string PunishDate { get; set; }

            [NameInMap("PunishLaw")]
            [Validation(Required=false)]
            public string PunishLaw { get; set; }

            [NameInMap("PunishNum")]
            [Validation(Required=false)]
            public string PunishNum { get; set; }

            [NameInMap("PunishRes")]
            [Validation(Required=false)]
            public string PunishRes { get; set; }

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
