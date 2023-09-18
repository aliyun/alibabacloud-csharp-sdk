// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class QueryBenefitGrantResultResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 123
        /// </summary>
        [NameInMap("Debug")]
        [Validation(Required=false)]
        public bool? Debug { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryBenefitGrantResultResponseBodyModel Model { get; set; }
        public class QueryBenefitGrantResultResponseBodyModel : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            /// <summary>
            /// 12345
            /// </summary>
            [NameInMap("CloudcodeFlowNo")]
            [Validation(Required=false)]
            public string CloudcodeFlowNo { get; set; }

            /// <summary>
            /// 12345
            /// </summary>
            [NameInMap("OuterCustomerId")]
            [Validation(Required=false)]
            public string OuterCustomerId { get; set; }

            /// <summary>
            /// 12345
            /// </summary>
            [NameInMap("OuterFlowNo")]
            [Validation(Required=false)]
            public string OuterFlowNo { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
