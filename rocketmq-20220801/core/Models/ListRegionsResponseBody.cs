// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListRegionsResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListRegionsResponseBodyData> Data { get; set; }
        public class ListRegionsResponseBodyData : TeaModel {
            /// <summary>
            /// The time when the ApsaraMQ for RocketMQ instance was created.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The region name.
            /// </summary>
            [NameInMap("regionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// Indicates whether ApsaraMQ for RocketMQ V4 is activated.
            /// </summary>
            [NameInMap("supportRocketmqV4")]
            [Validation(Required=false)]
            public bool? SupportRocketmqV4 { get; set; }

            /// <summary>
            /// Indicates whether ApsaraMQ for RocketMQ V5 is activated.
            /// </summary>
            [NameInMap("supportRocketmqV5")]
            [Validation(Required=false)]
            public bool? SupportRocketmqV5 { get; set; }

            /// <summary>
            /// The region tags.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListRegionsResponseBodyDataTags> Tags { get; set; }
            public class ListRegionsResponseBodyDataTags : TeaModel {
                /// <summary>
                /// The tag code.
                /// </summary>
                [NameInMap("tagCode")]
                [Validation(Required=false)]
                public string TagCode { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public object TagValue { get; set; }

            }

            /// <summary>
            /// The time when the ApsaraMQ for RocketMQ instance was last modified.
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

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
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
