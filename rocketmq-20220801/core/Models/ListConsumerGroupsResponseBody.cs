// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListConsumerGroupsResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The result data that is returned.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListConsumerGroupsResponseBodyData Data { get; set; }
        public class ListConsumerGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// The paginated data.
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListConsumerGroupsResponseBodyDataList> List { get; set; }
            public class ListConsumerGroupsResponseBodyDataList : TeaModel {
                /// <summary>
                /// The ID of the consumer group.
                /// </summary>
                [NameInMap("consumerGroupId")]
                [Validation(Required=false)]
                public string ConsumerGroupId { get; set; }

                /// <summary>
                /// The time when the consumer group was created.
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ID of the region in which the instance resides.
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The remarks on the consumer group.
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The state of the consumer group.
                /// 
                /// Valid values:
                /// 
                /// *   RUNNING
                /// 
                ///     <!-- -->
                /// 
                ///     : The consumer group is
                /// 
                ///     <!-- -->
                /// 
                ///     running
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// 
                /// *   CREATING
                /// 
                ///     <!-- -->
                /// 
                ///     : The consumer group is
                /// 
                ///     <!-- -->
                /// 
                ///     being created
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time when the consumer group was last updated.
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The dynamic error code.
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The dynamic error message.
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request. The system generates a unique ID for each request. You can troubleshoot issues based on the request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
