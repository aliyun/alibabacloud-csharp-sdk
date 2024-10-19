// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisWithStageNameIntegratedByAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorization information of the API.</para>
        /// </summary>
        [NameInMap("AppApiRelationInfos")]
        [Validation(Required=false)]
        public DescribeApisWithStageNameIntegratedByAppResponseBodyAppApiRelationInfos AppApiRelationInfos { get; set; }
        public class DescribeApisWithStageNameIntegratedByAppResponseBodyAppApiRelationInfos : TeaModel {
            [NameInMap("AppApiRelationInfo")]
            [Validation(Required=false)]
            public List<DescribeApisWithStageNameIntegratedByAppResponseBodyAppApiRelationInfosAppApiRelationInfo> AppApiRelationInfo { get; set; }
            public class DescribeApisWithStageNameIntegratedByAppResponseBodyAppApiRelationInfosAppApiRelationInfo : TeaModel {
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
                /// <para>The API description.</para>
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
                /// <para>manager_vehicles</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The request HTTP method of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>POST</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The authorizer. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PROVIDER:</b> the API owner</description></item>
                /// <item><description><b>CONSUMER:</b> the API caller</description></item>
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
                /// <para>The mapping information between environments and authorizations.</para>
                /// </summary>
                [NameInMap("StageNameAndAuth")]
                [Validation(Required=false)]
                public Dictionary<string, string> StageNameAndAuth { get; set; }

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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C87A26A-6A18-4B8E-8099-705278381A2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
