// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListInstagramPageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstagramPageResponseBodyData Data { get; set; }
        public class ListInstagramPageResponseBodyData : TeaModel {
            [NameInMap("AgentInfo")]
            [Validation(Required=false)]
            public ListInstagramPageResponseBodyDataAgentInfo AgentInfo { get; set; }
            public class ListInstagramPageResponseBodyDataAgentInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>aaa,bbb</para>
                /// </summary>
                [NameInMap("AgentKeywords")]
                [Validation(Required=false)]
                public string AgentKeywords { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("AgentNoKeywords")]
                [Validation(Required=false)]
                public string AgentNoKeywords { get; set; }

            }

            [NameInMap("BeebotInfo")]
            [Validation(Required=false)]
            public ListInstagramPageResponseBodyDataBeebotInfo BeebotInfo { get; set; }
            public class ListInstagramPageResponseBodyDataBeebotInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>instance1</para>
                /// </summary>
                [NameInMap("BeebotInstanceId")]
                [Validation(Required=false)]
                public string BeebotInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>name1</para>
                /// </summary>
                [NameInMap("BeebotNamespaceId")]
                [Validation(Required=false)]
                public string BeebotNamespaceId { get; set; }

            }

            [NameInMap("InstagramInfo")]
            [Validation(Required=false)]
            public ListInstagramPageResponseBodyDataInstagramInfo InstagramInfo { get; set; }
            public class ListInstagramPageResponseBodyDataInstagramInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>176546546464</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>matrryhtr</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>connected</para>
                /// </summary>
                [NameInMap("ConnectionStatus")]
                [Validation(Required=false)]
                public string ConnectionStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("HttpFlag")]
                [Validation(Required=false)]
                public string HttpFlag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>213254324532523</para>
                /// </summary>
                [NameInMap("PageId")]
                [Validation(Required=false)]
                public string PageId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>iwhaclecloud-2</para>
                /// </summary>
                [NameInMap("PageName")]
                [Validation(Required=false)]
                public string PageName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("QueueFlag")]
                [Validation(Required=false)]
                public string QueueFlag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="HTTP://WWW.***.COM">HTTP://WWW.***.COM</a></para>
                /// </summary>
                [NameInMap("StatusCallbackUrl")]
                [Validation(Required=false)]
                public string StatusCallbackUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AAA</para>
                /// </summary>
                [NameInMap("StatusQueue")]
                [Validation(Required=false)]
                public string StatusQueue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="HTTP://WWW.***.COM">HTTP://WWW.***.COM</a></para>
                /// </summary>
                [NameInMap("UpCallbackUrl")]
                [Validation(Required=false)]
                public string UpCallbackUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BBB</para>
                /// </summary>
                [NameInMap("UpQueue")]
                [Validation(Required=false)]
                public string UpQueue { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dsfdsf-3jfj***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
