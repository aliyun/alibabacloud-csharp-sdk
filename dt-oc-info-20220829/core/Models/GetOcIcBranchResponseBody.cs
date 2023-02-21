// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIcBranchResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcIcBranchResponseBodyData> Data { get; set; }
        public class GetOcIcBranchResponseBodyData : TeaModel {
            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("EntStatus")]
            [Validation(Required=false)]
            public string EntStatus { get; set; }

            [NameInMap("EsDate")]
            [Validation(Required=false)]
            public string EsDate { get; set; }

            [NameInMap("OperName")]
            [Validation(Required=false)]
            public string OperName { get; set; }

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
