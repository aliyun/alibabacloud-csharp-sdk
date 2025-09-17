// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MarketplaceIntl20221230.Models
{
    public class DescribePushMeteringDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>parameter \&quot;service\&quot; can not be blank.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceFatal")]
        [Validation(Required=false)]
        public bool? ForceFatal { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Instance 5723f7ee-952d-411f-94f4-b942a550d9b8 does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A6A33748-D573-593C-A3BC-593E33D68311</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribePushMeteringDataResponseBodyResult Result { get; set; }
        public class DescribePushMeteringDataResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-18T03:15:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5000002763123</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IsPushBilling")]
            [Validation(Required=false)]
            public bool? IsPushBilling { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sgcmgj0003XXXX-Period-1</para>
            /// </summary>
            [NameInMap("MeteringAssist")]
            [Validation(Required=false)]
            public string MeteringAssist { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;Frequency&quot;:1}</para>
            /// </summary>
            [NameInMap("MeteringEntity")]
            [Validation(Required=false)]
            public string MeteringEntity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pushData123456</para>
            /// </summary>
            [NameInMap("PushOrderBizId")]
            [Validation(Required=false)]
            public string PushOrderBizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-09T02:04:58Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
