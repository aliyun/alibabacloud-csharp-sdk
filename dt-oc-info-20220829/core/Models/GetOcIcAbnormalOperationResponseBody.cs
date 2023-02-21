// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIcAbnormalOperationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcIcAbnormalOperationResponseBodyData> Data { get; set; }
        public class GetOcIcAbnormalOperationResponseBodyData : TeaModel {
            [NameInMap("InDate")]
            [Validation(Required=false)]
            public string InDate { get; set; }

            [NameInMap("InDepartment")]
            [Validation(Required=false)]
            public string InDepartment { get; set; }

            [NameInMap("InReason")]
            [Validation(Required=false)]
            public string InReason { get; set; }

            [NameInMap("OutDate")]
            [Validation(Required=false)]
            public string OutDate { get; set; }

            [NameInMap("OutDepartment")]
            [Validation(Required=false)]
            public string OutDepartment { get; set; }

            [NameInMap("OutReason")]
            [Validation(Required=false)]
            public string OutReason { get; set; }

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
