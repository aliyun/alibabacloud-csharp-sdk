// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class AddCustomQAV2ResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddCustomQAV2ResponseBodyResult Result { get; set; }
        public class AddCustomQAV2ResponseBodyResult : TeaModel {
            [NameInMap("Answers")]
            [Validation(Required=false)]
            public string Answers { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            [NameInMap("KeyWords")]
            [Validation(Required=false)]
            public string KeyWords { get; set; }

            [NameInMap("LastOperator")]
            [Validation(Required=false)]
            public string LastOperator { get; set; }

            [NameInMap("MajorQuestion")]
            [Validation(Required=false)]
            public string MajorQuestion { get; set; }

            /// <summary>
            /// qaID
            /// </summary>
            [NameInMap("QaId")]
            [Validation(Required=false)]
            public string QaId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SupplementaryQuestion")]
            [Validation(Required=false)]
            public string SupplementaryQuestion { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
