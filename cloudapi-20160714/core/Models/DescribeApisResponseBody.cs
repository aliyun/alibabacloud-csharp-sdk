// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried API definitions.</para>
        /// </summary>
        [NameInMap("ApiSummarys")]
        [Validation(Required=false)]
        public DescribeApisResponseBodyApiSummarys ApiSummarys { get; set; }
        public class DescribeApisResponseBodyApiSummarys : TeaModel {
            [NameInMap("ApiSummary")]
            [Validation(Required=false)]
            public List<DescribeApisResponseBodyApiSummarysApiSummary> ApiSummary { get; set; }
            public class DescribeApisResponseBodyApiSummarysApiSummary : TeaModel {
                /// <summary>
                /// <para>The API ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5af418828f0344a3b588c0cc1331a3bc</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <para>The HTTP method of the API request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("ApiMethod")]
                [Validation(Required=false)]
                public string ApiMethod { get; set; }

                /// <summary>
                /// <para>The API name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CreateObject</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The request path of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/sqb/</para>
                /// </summary>
                [NameInMap("ApiPath")]
                [Validation(Required=false)]
                public string ApiPath { get; set; }

                /// <summary>
                /// <para>The time when the API was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-05-20T18:18:25Z</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The API publishing statuses.</para>
                /// </summary>
                [NameInMap("DeployedInfos")]
                [Validation(Required=false)]
                public DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfos DeployedInfos { get; set; }
                public class DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfos : TeaModel {
                    [NameInMap("DeployedInfo")]
                    [Validation(Required=false)]
                    public List<DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfosDeployedInfo> DeployedInfo { get; set; }
                    public class DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfosDeployedInfo : TeaModel {
                        /// <summary>
                        /// <para>The deployment status. Valid values: DEPLOYED and NONDEPLOYED.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DEPLOYED</para>
                        /// </summary>
                        [NameInMap("DeployedStatus")]
                        [Validation(Required=false)]
                        public string DeployedStatus { get; set; }

                        /// <summary>
                        /// <para>The deployed version.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20220103170737313</para>
                        /// </summary>
                        [NameInMap("EffectiveVersion")]
                        [Validation(Required=false)]
                        public string EffectiveVersion { get; set; }

                        /// <summary>
                        /// <para>Stage Name:</para>
                        /// <list type="bullet">
                        /// <item><description><b>RELEASE</b>: production environment</description></item>
                        /// <item><description><b>PRE</b>: staging environment</description></item>
                        /// <item><description><b>TEST</b>: test environment</description></item>
                        /// </list>
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
                /// <para>The API description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Creates an object</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The API group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1084f9034c744137901057206b39d2b6</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the API group to which the API belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myGroup2</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The time when the API was modified. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-07-23T08:28:48Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The ID of the region to which the API belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The tags that are added to the APIs.</para>
                /// </summary>
                [NameInMap("TagList")]
                [Validation(Required=false)]
                public DescribeApisResponseBodyApiSummarysApiSummaryTagList TagList { get; set; }
                public class DescribeApisResponseBodyApiSummarysApiSummaryTagList : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeApisResponseBodyApiSummarysApiSummaryTagListTag> Tag { get; set; }
                    public class DescribeApisResponseBodyApiSummarysApiSummaryTagListTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tagKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tagValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether the API is public. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PUBLIC</b>: The API is public.</description></item>
                /// <item><description><b>PRIVATE</b>: The API is private.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLIC</para>
                /// </summary>
                [NameInMap("Visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ002</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
