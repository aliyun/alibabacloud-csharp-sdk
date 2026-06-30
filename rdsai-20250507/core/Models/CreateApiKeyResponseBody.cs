// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateApiKeyResponseBodyData Data { get; set; }
        public class CreateApiKeyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The endpoint for model invocation.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx.yy/v1">http://xxx.yy/v1</a></para>
            /// </summary>
            [NameInMap("BaseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

            /// <summary>
            /// <para>The list of custom API keys.</para>
            /// </summary>
            [NameInMap("CustomKeyList")]
            [Validation(Required=false)]
            public List<CreateApiKeyResponseBodyDataCustomKeyList> CustomKeyList { get; set; }
            public class CreateApiKeyResponseBodyDataCustomKeyList : TeaModel {
                /// <summary>
                /// <para>The API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-rds-*****</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                [NameInMap("DailyTokenQuota")]
                [Validation(Required=false)]
                public long? DailyTokenQuota { get; set; }

                /// <summary>
                /// <para>The API key name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-*****</para>
                /// </summary>
                [NameInMap("KeyName")]
                [Validation(Required=false)]
                public string KeyName { get; set; }

                /// <summary>
                /// <para>The quota ratio. This parameter takes effect only when <b>LimitType</b> is set to <b>ratio</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("LimitRate")]
                [Validation(Required=false)]
                public float? LimitRate { get; set; }

                /// <summary>
                /// <para>The quota allocation method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>fixed</b>: The quota is a fixed value.</para>
                /// </description></item>
                /// <item><description><para><b>ratio</b>: The quota is specified as a ratio of the total available resources.</para>
                /// </description></item>
                /// <item><description><para><b>auto</b>: The quota is automatically allocated.</para>
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
                /// <para>100000</para>
                /// </summary>
                [NameInMap("TokenQuota")]
                [Validation(Required=false)]
                public long? TokenQuota { get; set; }

            }

            /// <summary>
            /// <para>The system-generated API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-rds-xxx</para>
            /// </summary>
            [NameInMap("SystemApiKey")]
            [Validation(Required=false)]
            public string SystemApiKey { get; set; }

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
        /// <para>The ID of the request.</para>
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
