// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListApiKeysResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListApiKeysResponseBodyData Data { get; set; }
        public class ListApiKeysResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxx.yy/v1">http://xxx.yy/v1</a></para>
            /// </summary>
            [NameInMap("BaseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

            [NameInMap("CustomKeyList")]
            [Validation(Required=false)]
            public List<ListApiKeysResponseBodyDataCustomKeyList> CustomKeyList { get; set; }
            public class ListApiKeysResponseBodyDataCustomKeyList : TeaModel {
                /// <summary>
                /// <para>API Key</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-rds-*****</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                [NameInMap("IsRateLimited")]
                [Validation(Required=false)]
                public bool? IsRateLimited { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>api-*****</para>
                /// </summary>
                [NameInMap("KeyName")]
                [Validation(Required=false)]
                public string KeyName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("LimitRate")]
                [Validation(Required=false)]
                public float? LimitRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fixed</para>
                /// </summary>
                [NameInMap("LimitType")]
                [Validation(Required=false)]
                public string LimitType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("TokenQuota")]
                [Validation(Required=false)]
                public long? TokenQuota { get; set; }

            }

            [NameInMap("IsRateLimited")]
            [Validation(Required=false)]
            public bool? IsRateLimited { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sk-rds-xxx</para>
            /// </summary>
            [NameInMap("SystemApiKey")]
            [Validation(Required=false)]
            public string SystemApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>138</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
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
