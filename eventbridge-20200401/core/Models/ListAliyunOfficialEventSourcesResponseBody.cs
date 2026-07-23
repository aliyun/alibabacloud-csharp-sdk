// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListAliyunOfficialEventSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The value Success indicates that the request is successful. Other values indicate that the request failed. For a list of error codes, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAliyunOfficialEventSourcesResponseBodyData Data { get; set; }
        public class ListAliyunOfficialEventSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The event sources.</para>
            /// </summary>
            [NameInMap("EventSourceList")]
            [Validation(Required=false)]
            public List<ListAliyunOfficialEventSourcesResponseBodyDataEventSourceList> EventSourceList { get; set; }
            public class ListAliyunOfficialEventSourcesResponseBodyDataEventSourceList : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the event bus.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:eventbridge:cn-hangzhou:SYSTEM:eventbus/default/eventsource/acs.arms</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The time when the event source was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1602730025890</para>
                /// </summary>
                [NameInMap("Ctime")]
                [Validation(Required=false)]
                public float? Ctime { get; set; }

                /// <summary>
                /// <para>The description of the event source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Elastic Compute Service</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the event source to which the event type belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("EventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

                /// <summary>
                /// <para>The event types.</para>
                /// </summary>
                [NameInMap("EventTypes")]
                [Validation(Required=false)]
                public List<ListAliyunOfficialEventSourcesResponseBodyDataEventSourceListEventTypes> EventTypes { get; set; }
                public class ListAliyunOfficialEventSourcesResponseBodyDataEventSourceListEventTypes : TeaModel {
                    /// <summary>
                    /// <para>The name of the event source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs.arms</para>
                    /// </summary>
                    [NameInMap("EventSourceName")]
                    [Validation(Required=false)]
                    public string EventSourceName { get; set; }

                    /// <summary>
                    /// <para>The name of the group to which the event type belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ActionTrail</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The full name of the event type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>arms:ActionTrail:AliyunServiceEvent</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The short name of the event type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AliyunServiceEven</para>
                    /// </summary>
                    [NameInMap("ShortName")]
                    [Validation(Required=false)]
                    public string ShortName { get; set; }

                }

                /// <summary>
                /// <para>The full name of the event source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Application Real-Time Monitoring Service</para>
                /// </summary>
                [NameInMap("FullName")]
                [Validation(Required=false)]
                public string FullName { get; set; }

                /// <summary>
                /// <para>The name of the event source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs.arms</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The status of the event source. Valid value: Activated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Activated</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the event source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AliyunOfficial</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidArgument</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5f80e9b3-98d5-4f51-8412-c758818a03e4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. If the operation is successful, the value true is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
