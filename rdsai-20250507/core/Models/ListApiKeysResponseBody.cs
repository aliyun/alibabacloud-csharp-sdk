// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListApiKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListApiKeysResponseBodyData Data { get; set; }
        public class ListApiKeysResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The base URL for model calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx.yy/v1">http://xxx.yy/v1</a></para>
            /// </summary>
            [NameInMap("BaseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

            /// <summary>
            /// <para>The custom API key list.</para>
            /// </summary>
            [NameInMap("CustomKeyList")]
            [Validation(Required=false)]
            public List<ListApiKeysResponseBodyDataCustomKeyList> CustomKeyList { get; set; }
            public class ListApiKeysResponseBodyDataCustomKeyList : TeaModel {
                /// <summary>
                /// <para>The API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-rds-*****</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100000000</para>
                /// </summary>
                [NameInMap("DailyTokenQuota")]
                [Validation(Required=false)]
                public long? DailyTokenQuota { get; set; }

                /// <summary>
                /// <para>Specifies if the API key is rate-limited.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsRateLimited")]
                [Validation(Required=false)]
                public bool? IsRateLimited { get; set; }

                /// <summary>
                /// <para>The key name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-*****</para>
                /// </summary>
                [NameInMap("KeyName")]
                [Validation(Required=false)]
                public string KeyName { get; set; }

                /// <summary>
                /// <para>The limit, specified as a ratio in decimal format. This parameter is used when LimitType is ratio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("LimitRate")]
                [Validation(Required=false)]
                public float? LimitRate { get; set; }

                /// <summary>
                /// <para>The limit type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>fixed</b>: A fixed value.</para>
                /// </description></item>
                /// <item><description><para><b>ratio</b>: A percentage of the total quota.</para>
                /// </description></item>
                /// <item><description><para><b>auto</b>: The quota is allocated automatically.</para>
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
                /// <para>The alarm threshold percentage. For example, a value of 80 indicates that an alarm is triggered when usage reaches 80% of the quota. The alarm clears when usage falls below this threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ThresholdPercent")]
                [Validation(Required=false)]
                public int? ThresholdPercent { get; set; }

                /// <summary>
                /// <para>The token quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("TokenQuota")]
                [Validation(Required=false)]
                public long? TokenQuota { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000000</para>
            /// </summary>
            [NameInMap("DailyTokenQuota")]
            [Validation(Required=false)]
            public long? DailyTokenQuota { get; set; }

            /// <summary>
            /// <para>Specifies if the system-generated key is rate-limited.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsRateLimited")]
            [Validation(Required=false)]
            public bool? IsRateLimited { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The system-generated key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-rds-xxx</para>
            /// </summary>
            [NameInMap("SystemApiKey")]
            [Validation(Required=false)]
            public string SystemApiKey { get; set; }

            /// <summary>
            /// <para>The alarm threshold percentage for the SystemApiKey. For example, a value of 80 indicates that an alarm is triggered when usage reaches 80% of the quota. The alarm clears when usage falls below this threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ThresholdPercent")]
            [Validation(Required=false)]
            public int? ThresholdPercent { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>138</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates if the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
