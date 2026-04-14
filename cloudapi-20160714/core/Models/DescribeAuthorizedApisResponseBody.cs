// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAuthorizedApisResponseBody : TeaModel {
        [NameInMap("AuthorizedApis")]
        [Validation(Required=false)]
        public DescribeAuthorizedApisResponseBodyAuthorizedApis AuthorizedApis { get; set; }
        public class DescribeAuthorizedApisResponseBodyAuthorizedApis : TeaModel {
            [NameInMap("AuthorizedApi")]
            [Validation(Required=false)]
            public List<DescribeAuthorizedApisResponseBodyAuthorizedApisAuthorizedApi> AuthorizedApi { get; set; }
            public class DescribeAuthorizedApisResponseBodyAuthorizedApisAuthorizedApi : TeaModel {
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                [NameInMap("AuthVaildTime")]
                [Validation(Required=false)]
                public string AuthVaildTime { get; set; }

                [NameInMap("AuthorizationSource")]
                [Validation(Required=false)]
                public string AuthorizationSource { get; set; }

                [NameInMap("AuthorizedTime")]
                [Validation(Required=false)]
                public string AuthorizedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

            }

        }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6E46F10-F26C-4AA0-BB69-FE2743D9AE62</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
