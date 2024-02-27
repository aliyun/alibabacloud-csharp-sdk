// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class ExportCustomerQuotaRecordResponseBody : TeaModel {
        /// <summary>
        /// Code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExportCustomerQuotaRecordResponseBodyData Data { get; set; }
        public class ExportCustomerQuotaRecordResponseBodyData : TeaModel {
            /// <summary>
            /// Estimated duration, in minutes.
            /// </summary>
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public int? Cost { get; set; }

            /// <summary>
            /// ID of Export task
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        /// <summary>
        /// Description
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// ID of the Request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
