// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceAuthorizedApisResponseBody : TeaModel {
        /// <summary>
        /// The information about the APIs that you are authorized to access.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataServiceAuthorizedApisResponseBodyData Data { get; set; }
        public class ListDataServiceAuthorizedApisResponseBodyData : TeaModel {
            /// <summary>
            /// The APIs that you are authorized to access.
            /// </summary>
            [NameInMap("ApiAuthorizedList")]
            [Validation(Required=false)]
            public List<ListDataServiceAuthorizedApisResponseBodyDataApiAuthorizedList> ApiAuthorizedList { get; set; }
            public class ListDataServiceAuthorizedApisResponseBodyDataApiAuthorizedList : TeaModel {
                /// <summary>
                /// The API ID.
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public long? ApiId { get; set; }

                /// <summary>
                /// The name of the API.
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// The path of the API.
                /// </summary>
                [NameInMap("ApiPath")]
                [Validation(Required=false)]
                public string ApiPath { get; set; }

                /// <summary>
                /// The status of the API. Valid values: 0 and 1. The value 0 indicates that the API is not published. The value 1 indicates that the API is published.
                /// </summary>
                [NameInMap("ApiStatus")]
                [Validation(Required=false)]
                public int? ApiStatus { get; set; }

                /// <summary>
                /// The time when the API was created.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used by the API owner.
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// The time when the access permissions on the API were granted.
                /// </summary>
                [NameInMap("GrantCreatedTime")]
                [Validation(Required=false)]
                public string GrantCreatedTime { get; set; }

                /// <summary>
                /// The expiration time of the access permissions granted on the API.
                /// </summary>
                [NameInMap("GrantEndTime")]
                [Validation(Required=false)]
                public string GrantEndTime { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used by the user who granted the access permissions on the API.
                /// </summary>
                [NameInMap("GrantOperatorId")]
                [Validation(Required=false)]
                public string GrantOperatorId { get; set; }

                /// <summary>
                /// The group ID.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The time when the API was last updated.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The workspace ID.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// The tenant ID.
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// The page number. The value of this parameter is the same as that of the PageNumber parameter in the request.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page. Default value: 10. Maximum value: 100.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
