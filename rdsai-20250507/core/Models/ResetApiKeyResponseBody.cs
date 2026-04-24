// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ResetApiKeyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ResetApiKeyResponseBodyData Data { get; set; }
        public class ResetApiKeyResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sk-rds-*****</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxx.yy/v1">http://xxx.yy/v1</a></para>
            /// </summary>
            [NameInMap("BaseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

            [NameInMap("CustomKeyList")]
            [Validation(Required=false)]
            public List<ResetApiKeyResponseBodyDataCustomKeyList> CustomKeyList { get; set; }
            public class ResetApiKeyResponseBodyDataCustomKeyList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>sk-rds-*****</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>api-*****</para>
                /// </summary>
                [NameInMap("KeyName")]
                [Validation(Required=false)]
                public string KeyName { get; set; }

            }

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
        /// <para>FE9C65D7-930F-57A5-A207-8C396329241C</para>
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
