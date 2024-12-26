// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MissingInstanceId</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMessagesResponseBodyData Data { get; set; }
        public class ListMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListMessagesResponseBodyDataList> List { get; set; }
            public class ListMessagesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Message body.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                /// <summary>
                /// <para>Message body size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("bodySize")]
                [Validation(Required=false)]
                public int? BodySize { get; set; }

                /// <summary>
                /// <para>The client on which messages are produced.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx.xx.xx</para>
                /// </summary>
                [NameInMap("bornHost")]
                [Validation(Required=false)]
                public string BornHost { get; set; }

                /// <summary>
                /// <para>Message born time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-22 12:17:08</para>
                /// </summary>
                [NameInMap("bornTime")]
                [Validation(Required=false)]
                public string BornTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rmq-cn-7e22ody****</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The message group. This parameter is returned only for ordered messages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("messageGroup")]
                [Validation(Required=false)]
                public string MessageGroup { get; set; }

                /// <summary>
                /// <para>Message Id.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7F000001000114B4340C5ABF94500079</para>
                /// </summary>
                [NameInMap("messageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <para>Message keys.</para>
                /// </summary>
                [NameInMap("messageKeys")]
                [Validation(Required=false)]
                public List<string> MessageKeys { get; set; }

                /// <summary>
                /// <para>The message tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("messageTag")]
                [Validation(Required=false)]
                public string MessageTag { get; set; }

                /// <summary>
                /// <para>Message type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("messageType")]
                [Validation(Required=false)]
                public string MessageType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The broker on which messages are stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx.xx.xx</para>
                /// </summary>
                [NameInMap("storeHost")]
                [Validation(Required=false)]
                public string StoreHost { get; set; }

                /// <summary>
                /// <para>Message store time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-22 12:17:08</para>
                /// </summary>
                [NameInMap("storeTime")]
                [Validation(Required=false)]
                public string StoreTime { get; set; }

                /// <summary>
                /// <para>The name of the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>topic_test</para>
                /// </summary>
                [NameInMap("topicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                /// <summary>
                /// <para>Message user properties.</para>
                /// </summary>
                [NameInMap("userProperties")]
                [Validation(Required=false)]
                public Dictionary<string, string> UserProperties { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The scroll ID of the request.</para>
            /// <para>The ID is automatically generated by the system. The result can be paginated only if this parameter is included in the pagination request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B13D0B07-F24B-4790-88D8-D47A38063D00</para>
            /// </summary>
            [NameInMap("scrollId")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter instanceId is mandatory for this action .</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3531B6A-5A88-52BD-B3C4-A024C3D0AA2E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
