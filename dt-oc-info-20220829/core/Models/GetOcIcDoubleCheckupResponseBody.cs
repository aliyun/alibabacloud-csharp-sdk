// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIcDoubleCheckupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcIcDoubleCheckupResponseBodyData> Data { get; set; }
        public class GetOcIcDoubleCheckupResponseBodyData : TeaModel {
            [NameInMap("InspectDate")]
            [Validation(Required=false)]
            public string InspectDate { get; set; }

            [NameInMap("InspectDepartment")]
            [Validation(Required=false)]
            public string InspectDepartment { get; set; }

            [NameInMap("InspectItem")]
            [Validation(Required=false)]
            public string InspectItem { get; set; }

            [NameInMap("InspectPlanId")]
            [Validation(Required=false)]
            public string InspectPlanId { get; set; }

            [NameInMap("InspectPlanName")]
            [Validation(Required=false)]
            public string InspectPlanName { get; set; }

            [NameInMap("InspectResult")]
            [Validation(Required=false)]
            public string InspectResult { get; set; }

            [NameInMap("InspectTaskId")]
            [Validation(Required=false)]
            public string InspectTaskId { get; set; }

            [NameInMap("InspectTaskName")]
            [Validation(Required=false)]
            public string InspectTaskName { get; set; }

            [NameInMap("InspectTypeName")]
            [Validation(Required=false)]
            public string InspectTypeName { get; set; }

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
