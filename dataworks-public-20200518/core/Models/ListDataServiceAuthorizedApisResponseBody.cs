// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceAuthorizedApisResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the APIs that you are authorized to access.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataServiceAuthorizedApisResponseBodyData Data { get; set; }
        public class ListDataServiceAuthorizedApisResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The APIs that you are authorized to access.</para>
            /// </summary>
            [NameInMap("ApiAuthorizedList")]
            [Validation(Required=false)]
            public List<ListDataServiceAuthorizedApisResponseBodyDataApiAuthorizedList> ApiAuthorizedList { get; set; }
            public class ListDataServiceAuthorizedApisResponseBodyDataApiAuthorizedList : TeaModel {
                /// <summary>
                /// <para>The API ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10002</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public long? ApiId { get; set; }

                /// <summary>
                /// <para>The name of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>My API Name</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The path of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test/1</para>
                /// </summary>
                [NameInMap("ApiPath")]
                [Validation(Required=false)]
                public string ApiPath { get; set; }

                /// <summary>
                /// <para>The status of the API. Valid values: 0 and 1. The value 0 indicates that the API is not published. The value 1 indicates that the API is published.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ApiStatus")]
                [Validation(Required=false)]
                public int? ApiStatus { get; set; }

                /// <summary>
                /// <para>The time when the API was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-23T00:21:01+0800</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the API owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The time when the access permissions on the API were granted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-23T00:21:01+0800</para>
                /// </summary>
                [NameInMap("GrantCreatedTime")]
                [Validation(Required=false)]
                public string GrantCreatedTime { get; set; }

                /// <summary>
                /// <para>The expiration time of the access permissions granted on the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-24T00:21:01+0800</para>
                /// </summary>
                [NameInMap("GrantEndTime")]
                [Validation(Required=false)]
                public string GrantEndTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the user who granted the access permissions on the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23456</para>
                /// </summary>
                [NameInMap("GrantOperatorId")]
                [Validation(Required=false)]
                public string GrantOperatorId { get; set; }

                /// <summary>
                /// <para>The group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcde123456789</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The time when the API was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-23T00:21:01+0800</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// <para>The page number. The value of this parameter is the same as that of the PageNumber parameter in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1031203110005</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameters are invalid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
