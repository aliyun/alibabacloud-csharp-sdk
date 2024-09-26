// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListTopicsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the events returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTopicsResponseBodyData Data { get; set; }
        public class ListTopicsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The events returned.</para>
            /// </summary>
            [NameInMap("Topics")]
            [Validation(Required=false)]
            public List<ListTopicsResponseBodyDataTopics> Topics { get; set; }
            public class ListTopicsResponseBodyDataTopics : TeaModel {
                /// <summary>
                /// <para>The timestamp when the event was found.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553524393000</para>
                /// </summary>
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public long? AddTime { get; set; }

                /// <summary>
                /// <para>The timestamp when the event was processed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553508465000</para>
                /// </summary>
                [NameInMap("FixTime")]
                [Validation(Required=false)]
                public long? FixTime { get; set; }

                /// <summary>
                /// <para>The timestamp when the event occurred. A time difference may exist between the time when the event occurred and the time when the event was found.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553508465000</para>
                /// </summary>
                [NameInMap("HappenTime")]
                [Validation(Required=false)]
                public long? HappenTime { get; set; }

                /// <summary>
                /// <para>The ID of the node instance that triggers the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the node that triggers the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Node Name</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that is used by the node owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>952795****</para>
                /// </summary>
                [NameInMap("NodeOwner")]
                [Validation(Required=false)]
                public string NodeOwner { get; set; }

                /// <summary>
                /// <para>The ID of the workspace to which the node belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The ID of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public long? TopicId { get; set; }

                /// <summary>
                /// <para>The name of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234 Error</para>
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                /// <summary>
                /// <para>The status of the event. Valid values: IGNORE, NEW, FIXING, and RECOVER. The value IGNORE indicates that the event is ignored. The value NEW indicates that the event is a new event. The value FIXING indicates that the event is being processed. The value RECOVER indicates that the event is processed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NEW</para>
                /// </summary>
                [NameInMap("TopicStatus")]
                [Validation(Required=false)]
                public string TopicStatus { get; set; }

                /// <summary>
                /// <para>The type of the event. Valid values: SLOW and ERROR. The value SLOW indicates that the running duration of the node in the current scheduling cycle is significantly longer than the average running duration of the node in previous scheduling cycles. The value ERROR indicates that the node fails to run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ERROR</para>
                /// </summary>
                [NameInMap("TopicType")]
                [Validation(Required=false)]
                public string TopicType { get; set; }

            }

            /// <summary>
            /// <para>The total number of the events returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1031203110005</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameters are invalid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
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
