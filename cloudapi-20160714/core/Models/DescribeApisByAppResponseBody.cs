// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisByAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The API authorizations.</para>
        /// </summary>
        [NameInMap("AppApiRelationInfos")]
        [Validation(Required=false)]
        public DescribeApisByAppResponseBodyAppApiRelationInfos AppApiRelationInfos { get; set; }
        public class DescribeApisByAppResponseBodyAppApiRelationInfos : TeaModel {
            [NameInMap("AppApiRelationInfo")]
            [Validation(Required=false)]
            public List<DescribeApisByAppResponseBodyAppApiRelationInfosAppApiRelationInfo> AppApiRelationInfo { get; set; }
            public class DescribeApisByAppResponseBodyAppApiRelationInfosAppApiRelationInfo : TeaModel {
                /// <summary>
                /// <para>The API ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c625795a1e664782a918eaa629e96ab5</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <para>The API name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sd2_h5_player_history_competition</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The validity period of the authorization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sun, 02 Jan 2022 16:00:00 GMT</para>
                /// </summary>
                [NameInMap("AuthVaildTime")]
                [Validation(Required=false)]
                public string AuthVaildTime { get; set; }

                /// <summary>
                /// <para>The authorization source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELF</para>
                /// </summary>
                [NameInMap("AuthorizationSource")]
                [Validation(Required=false)]
                public string AuthorizationSource { get; set; }

                /// <summary>
                /// <para>The time when the authorization was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sun, 02 Jan 2022 16:00:00 GMT</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The authorization description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b1008kz</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>38bed48d664149e4b9b5ea576319673f</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wb2022012101605749</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The HTTP method of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The authorizer. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PROVIDER</b>: API owner</description></item>
                /// <item><description><b>CONSUMER</b>: API caller</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PROVIDER</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The request path of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/api/offline/cacheData</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The environment alias.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Online</para>
                /// </summary>
                [NameInMap("StageAlias")]
                [Validation(Required=false)]
                public string StageAlias { get; set; }

                /// <summary>
                /// <para>The environment name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RELEASE</para>
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of pages to return the results on.</para>
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
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ015</para>
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
