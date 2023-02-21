// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIpWorksCopyrightResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcIpWorksCopyrightResponseBodyData> Data { get; set; }
        public class GetOcIpWorksCopyrightResponseBodyData : TeaModel {
            [NameInMap("ApprovalDate")]
            [Validation(Required=false)]
            public string ApprovalDate { get; set; }

            [NameInMap("CopyName")]
            [Validation(Required=false)]
            public string CopyName { get; set; }

            [NameInMap("CopyNum")]
            [Validation(Required=false)]
            public string CopyNum { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("FirstDate")]
            [Validation(Required=false)]
            public string FirstDate { get; set; }

            [NameInMap("SuccessDate")]
            [Validation(Required=false)]
            public string SuccessDate { get; set; }

            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

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
