// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceApiAuthoritiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of APIs authorized to other users.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataServiceApiAuthoritiesResponseBodyData Data { get; set; }
        public class ListDataServiceApiAuthoritiesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The response structure.</para>
            /// </summary>
            [NameInMap("ApiAuthorizationList")]
            [Validation(Required=false)]
            public List<ListDataServiceApiAuthoritiesResponseBodyDataApiAuthorizationList> ApiAuthorizationList { get; set; }
            public class ListDataServiceApiAuthoritiesResponseBodyDataApiAuthorizationList : TeaModel {
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
                /// <para>MyAPIName</para>
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
                /// <para>The status of the API. Valid values: 0: unpublished. 1: published.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ApiStatus")]
                [Validation(Required=false)]
                public int? ApiStatus { get; set; }

                /// <summary>
                /// <para>The list of authorization details for APIs authorized to other users.</para>
                /// </summary>
                [NameInMap("AuthorizationRecords")]
                [Validation(Required=false)]
                public List<ListDataServiceApiAuthoritiesResponseBodyDataApiAuthorizationListAuthorizationRecords> AuthorizationRecords { get; set; }
                public class ListDataServiceApiAuthoritiesResponseBodyDataApiAuthorizationListAuthorizationRecords : TeaModel {
                    /// <summary>
                    /// <para>The authorization time, in the yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ format (the example time zone is +0800).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-06-23T00:21:01+0800</para>
                    /// </summary>
                    [NameInMap("CreatedTime")]
                    [Validation(Required=false)]
                    public string CreatedTime { get; set; }

                    /// <summary>
                    /// <para>The Alibaba Cloud ID of the API owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("CreatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    /// <summary>
                    /// <para>The end time of the authorization validity period, in the yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ format (the example time zone is +0800).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-06-24T00:21:01+0800</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The workspace ID that has been granted the authorization.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10004</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                }

                /// <summary>
                /// <para>The time when the API was created, in the yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ format (the example time zone is +0800).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-23T00:21:01+0800</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud ID of the API owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ab123</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The time when the API was last modified, in the yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ format (the example time zone is +0800).</para>
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
            /// <para>The page number, which is the same as the PageNumber value in the request.</para>
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
            /// <para>The total number of records.</para>
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
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
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
        /// <para>The request ID. A unique identifier for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
