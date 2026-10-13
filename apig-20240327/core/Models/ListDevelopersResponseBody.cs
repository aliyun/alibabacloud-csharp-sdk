// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListDevelopersResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListDevelopersResponseBodyData Data { get; set; }
        public class ListDevelopersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of developers.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<ListDevelopersResponseBodyDataContent> Content { get; set; }
            public class ListDevelopersResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The developer ID. You can use this ID to locate the developer in API operations such as SetHiMarketDeveloperStatus and DeleteHiMarketDeveloper.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev-xxxxxxxx</para>
                /// </summary>
                [NameInMap("developerId")]
                [Validation(Required=false)]
                public string DeveloperId { get; set; }

                /// <summary>
                /// <para>The ID of the portal to which the developer belongs. You can use this ID to locate the portal in API operations such as GetPortal, UpdatePortal, and DeletePortal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>portal-xxxxxxxx</para>
                /// </summary>
                [NameInMap("portalId")]
                [Validation(Required=false)]
                public string PortalId { get; set; }

                /// <summary>
                /// <para>The status of the developer. Valid values: PENDING, APPROVED, and REJECTED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>APPROVED</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The logon username of the developer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>developer-demo</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The cursor for the next page. An empty value indicates that the last page has been reached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-xxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
