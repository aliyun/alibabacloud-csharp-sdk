// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryTagApplyRuleResponseBody : TeaModel {
        /// <summary>
        /// The response code. **OK** indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTagApplyRuleResponseBodyData Data { get; set; }
        public class QueryTagApplyRuleResponseBodyData : TeaModel {
            /// <summary>
            /// The requirements for application materials.
            /// </summary>
            [NameInMap("ApplyMaterialDesc")]
            [Validation(Required=false)]
            public string ApplyMaterialDesc { get; set; }

            /// <summary>
            /// Indicates whether the application is automatically approved.
            /// </summary>
            [NameInMap("AutoAudit")]
            [Validation(Required=false)]
            public long? AutoAudit { get; set; }

            /// <summary>
            /// The URL for the billing documentation.
            /// </summary>
            [NameInMap("ChargingStandardLink")]
            [Validation(Required=false)]
            public string ChargingStandardLink { get; set; }

            /// <summary>
            /// indicates whether encrypted queries are supported.
            /// </summary>
            [NameInMap("EncryptedQuery")]
            [Validation(Required=false)]
            public long? EncryptedQuery { get; set; }

            /// <summary>
            /// Indicates whether application materials are required.
            /// </summary>
            [NameInMap("NeedApplyMaterial")]
            [Validation(Required=false)]
            public long? NeedApplyMaterial { get; set; }

            /// <summary>
            /// The URL for the service agreement.
            /// </summary>
            [NameInMap("SlaLink")]
            [Validation(Required=false)]
            public string SlaLink { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
