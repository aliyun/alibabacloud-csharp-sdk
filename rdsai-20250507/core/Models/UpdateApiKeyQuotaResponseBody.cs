// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateApiKeyQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateApiKeyQuotaResponseBodyData Data { get; set; }
        public class UpdateApiKeyQuotaResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of custom API keys.</para>
            /// </summary>
            [NameInMap("CustomKeyList")]
            [Validation(Required=false)]
            public List<UpdateApiKeyQuotaResponseBodyDataCustomKeyList> CustomKeyList { get; set; }
            public class UpdateApiKeyQuotaResponseBodyDataCustomKeyList : TeaModel {
                /// <summary>
                /// <para>The API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-rds-xxx</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000000000</para>
                /// </summary>
                [NameInMap("DailyTokenQuota")]
                [Validation(Required=false)]
                public long? DailyTokenQuota { get; set; }

                /// <summary>
                /// <para>The limit rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("LimitRate")]
                [Validation(Required=false)]
                public float? LimitRate { get; set; }

                /// <summary>
                /// <para>The quota limiting method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>ratio</c>: Sets the limit based on a ratio.</para>
                /// </description></item>
                /// <item><description><para><c>fixed</c>: Sets the limit to a fixed value.</para>
                /// </description></item>
                /// <item><description><para><c>auto</c>: Allocates the limit automatically.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>fixed</para>
                /// </summary>
                [NameInMap("LimitType")]
                [Validation(Required=false)]
                public string LimitType { get; set; }

                /// <summary>
                /// <para>The token quota for the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("TokenQuota")]
                [Validation(Required=false)]
                public long? TokenQuota { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
