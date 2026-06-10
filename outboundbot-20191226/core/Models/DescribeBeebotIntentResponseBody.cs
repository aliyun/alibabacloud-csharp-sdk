// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeBeebotIntentResponseBody : TeaModel {
        /// <summary>
        /// <para>Internal request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B219FCB-EC71-1F08-BB1B-0E87C20158C8</para>
        /// </summary>
        [NameInMap("BeebotRequestId")]
        [Validation(Required=false)]
        public string BeebotRequestId { get; set; }

        /// <summary>
        /// <para>API status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Intent information</para>
        /// </summary>
        [NameInMap("Intent")]
        [Validation(Required=false)]
        public DescribeBeebotIntentResponseBodyIntent Intent { get; set; }
        public class DescribeBeebotIntentResponseBodyIntent : TeaModel {
            /// <summary>
            /// <para>Intent alias</para>
            /// 
            /// <b>Example:</b>
            /// <para>嗯明白了</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-21 10:29:59.+0800</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Creator user ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1252504</para>
            /// </summary>
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public string CreateUserId { get; set; }

            /// <summary>
            /// <para>Creator account name</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:xxx@voice-navigator-testonaliyun.com">xxx@voice-navigator-testonaliyun.com</a></para>
            /// </summary>
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// <para>Intent ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>10717802</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }

            /// <summary>
            /// <para>Intent name</para>
            /// 
            /// <b>Example:</b>
            /// <para>知道了</para>
            /// </summary>
            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

            /// <summary>
            /// <para>Modification time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-21 15:52:57.+0800</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>Modifier user ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1252504</para>
            /// </summary>
            [NameInMap("ModifyUserId")]
            [Validation(Required=false)]
            public string ModifyUserId { get; set; }

            /// <summary>
            /// <para>Modifier account name</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:xxx@voice-navigator-testonaliyun.com">xxx@voice-navigator-testonaliyun.com</a></para>
            /// </summary>
            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

        }

        /// <summary>
        /// <para>Intent ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>10717802</para>
        /// </summary>
        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public long? IntentId { get; set; }

        /// <summary>
        /// <para>API message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
