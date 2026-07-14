// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListInstagramPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of OK indicates that the request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstagramPageResponseBodyData Data { get; set; }
        public class ListInstagramPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The agent information.</para>
            /// </summary>
            [NameInMap("AgentInfo")]
            [Validation(Required=false)]
            public ListInstagramPageResponseBodyDataAgentInfo AgentInfo { get; set; }
            public class ListInstagramPageResponseBodyDataAgentInfo : TeaModel {
                /// <summary>
                /// <para>The agent-related configurations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaa,bbb</para>
                /// </summary>
                [NameInMap("AgentKeywords")]
                [Validation(Required=false)]
                public string AgentKeywords { get; set; }

                /// <summary>
                /// <para>The agent-related configurations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("AgentNoKeywords")]
                [Validation(Required=false)]
                public string AgentNoKeywords { get; set; }

            }

            /// <summary>
            /// <para>The Chatbot information.</para>
            /// </summary>
            [NameInMap("BeebotInfo")]
            [Validation(Required=false)]
            public ListInstagramPageResponseBodyDataBeebotInfo BeebotInfo { get; set; }
            public class ListInstagramPageResponseBodyDataBeebotInfo : TeaModel {
                /// <summary>
                /// <para>The Chatbot instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance1</para>
                /// </summary>
                [NameInMap("BeebotInstanceId")]
                [Validation(Required=false)]
                public string BeebotInstanceId { get; set; }

                /// <summary>
                /// <para>The namespace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name1</para>
                /// </summary>
                [NameInMap("BeebotNamespaceId")]
                [Validation(Required=false)]
                public string BeebotNamespaceId { get; set; }

            }

            /// <summary>
            /// <para>The Instagram page information.</para>
            /// </summary>
            [NameInMap("InstagramInfo")]
            [Validation(Required=false)]
            public ListInstagramPageResponseBodyDataInstagramInfo InstagramInfo { get; set; }
            public class ListInstagramPageResponseBodyDataInstagramInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the account to which the page belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>176546546464</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>The account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>matrryhtr</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The endpoint connection status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Pending</b>: Being modified.</para>
                /// </description></item>
                /// <item><description><para><b>Connecting</b>: Connecting.</para>
                /// </description></item>
                /// <item><description><para><b>Connected</b>: Connected.</para>
                /// </description></item>
                /// <item><description><para><b>Disconnecting</b>: Disconnecting.</para>
                /// </description></item>
                /// <item><description><para><b>Disconnected</b>: Not connected.</para>
                /// </description></item>
                /// <item><description><para><b>Deleting</b>: Being deleted.</para>
                /// </description></item>
                /// <item><description><para><b>ServiceDeleted</b>: The service associated with the endpoint has been deleted.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>connected</para>
                /// </summary>
                [NameInMap("ConnectionStatus")]
                [Validation(Required=false)]
                public string ConnectionStatus { get; set; }

                /// <summary>
                /// <para>Indicates whether receipts are received through HTTP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Y: Yes.</description></item>
                /// <item><description>N: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("HttpFlag")]
                [Validation(Required=false)]
                public string HttpFlag { get; set; }

                /// <summary>
                /// <para>The page ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>213254324532523</para>
                /// </summary>
                [NameInMap("PageId")]
                [Validation(Required=false)]
                public string PageId { get; set; }

                /// <summary>
                /// <para>The page name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iwhaclecloud-2</para>
                /// </summary>
                [NameInMap("PageName")]
                [Validation(Required=false)]
                public string PageName { get; set; }

                /// <summary>
                /// <para>Indicates whether receipts are received through a queue. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Y: Yes.</para>
                /// </description></item>
                /// <item><description><para>N: No.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("QueueFlag")]
                [Validation(Required=false)]
                public string QueueFlag { get; set; }

                /// <summary>
                /// <para>The queue name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The callback URL for status reports over HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="HTTP://WWW.***.COM">HTTP://WWW.***.COM</a></para>
                /// </summary>
                [NameInMap("StatusCallbackUrl")]
                [Validation(Required=false)]
                public string StatusCallbackUrl { get; set; }

                /// <summary>
                /// <para>The queue for status report notifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AAA</para>
                /// </summary>
                [NameInMap("StatusQueue")]
                [Validation(Required=false)]
                public string StatusQueue { get; set; }

                /// <summary>
                /// <para>The callback URL for upstream messages over HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="HTTP://WWW.***.COM">HTTP://WWW.***.COM</a></para>
                /// </summary>
                [NameInMap("UpCallbackUrl")]
                [Validation(Required=false)]
                public string UpCallbackUrl { get; set; }

                /// <summary>
                /// <para>The queue for upstream message notifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BBB</para>
                /// </summary>
                [NameInMap("UpQueue")]
                [Validation(Required=false)]
                public string UpQueue { get; set; }

            }

        }

        /// <summary>
        /// <para>The message returned with the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. It is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsfdsf-3jfj***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Successful.</para>
        /// </description></item>
        /// <item><description><para>false: Failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
