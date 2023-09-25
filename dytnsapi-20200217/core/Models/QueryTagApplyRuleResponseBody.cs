// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryTagApplyRuleResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTagApplyRuleResponseBodyData Data { get; set; }
        public class QueryTagApplyRuleResponseBodyData : TeaModel {
            /// <summary>
            /// 申请材料要求
            /// </summary>
            [NameInMap("ApplyMaterialDesc")]
            [Validation(Required=false)]
            public string ApplyMaterialDesc { get; set; }

            /// <summary>
            /// 是否自动审批
            /// </summary>
            [NameInMap("AutoAudit")]
            [Validation(Required=false)]
            public long? AutoAudit { get; set; }

            /// <summary>
            /// 计费标准说明链接
            /// </summary>
            [NameInMap("ChargingStandardLink")]
            [Validation(Required=false)]
            public string ChargingStandardLink { get; set; }

            /// <summary>
            /// 是否支持加密查询
            /// </summary>
            [NameInMap("EncryptedQuery")]
            [Validation(Required=false)]
            public long? EncryptedQuery { get; set; }

            /// <summary>
            /// 是否需要提供申请材料
            /// </summary>
            [NameInMap("NeedApplyMaterial")]
            [Validation(Required=false)]
            public long? NeedApplyMaterial { get; set; }

            /// <summary>
            /// 服务协议链接
            /// </summary>
            [NameInMap("SlaLink")]
            [Validation(Required=false)]
            public string SlaLink { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
