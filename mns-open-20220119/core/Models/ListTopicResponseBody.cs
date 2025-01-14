// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListTopicResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTopicResponseBodyData Data { get; set; }
        public class ListTopicResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data returned on the current page.</para>
            /// </summary>
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListTopicResponseBodyDataPageData> PageData { get; set; }
            public class ListTopicResponseBodyDataPageData : TeaModel {
                /// <summary>
                /// <para>The time when the subscription was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1449554962</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the subscription was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1449554962</para>
                /// </summary>
                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public long? LastModifyTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the logging feature is enabled.</para>
                /// <list type="bullet">
                /// <item><description>True</description></item>
                /// <item><description>False</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("LoggingEnabled")]
                [Validation(Required=false)]
                public bool? LoggingEnabled { get; set; }

                /// <summary>
                /// <para>The maximum length of the message that is sent to the topic. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65536</para>
                /// </summary>
                [NameInMap("MaxMessageSize")]
                [Validation(Required=false)]
                public long? MaxMessageSize { get; set; }

                /// <summary>
                /// <para>The number of messages in the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MessageCount")]
                [Validation(Required=false)]
                public long? MessageCount { get; set; }

                /// <summary>
                /// <para>The maximum duration for which a message is retained in the topic. After the specified retention period ends, the message is deleted regardless of whether the message is received. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("MessageRetentionPeriod")]
                [Validation(Required=false)]
                public long? MessageRetentionPeriod { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListTopicResponseBodyDataPageDataTags> Tags { get; set; }
                public class ListTopicResponseBodyDataPageDataTags : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                [NameInMap("TopicInnerUrl")]
                [Validation(Required=false)]
                public string TopicInnerUrl { get; set; }

                /// <summary>
                /// <para>The name of the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo-topic</para>
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                [NameInMap("TopicUrl")]
                [Validation(Required=false)]
                public string TopicUrl { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06273500-249F-5863-121D-74D51123****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

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
