// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class VerifyLogisticsSmsMailNoResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public VerifyLogisticsSmsMailNoResponseBodyData Data { get; set; }
        public class VerifyLogisticsSmsMailNoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("ExpressCompanyCode")]
            [Validation(Required=false)]
            public string ExpressCompanyCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("MobileSuffix")]
            [Validation(Required=false)]
            public string MobileSuffix { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public bool? VerifyResult { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
