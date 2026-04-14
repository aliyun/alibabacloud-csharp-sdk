// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisResponseBody : TeaModel {
        [NameInMap("ApiSummarys")]
        [Validation(Required=false)]
        public DescribeApisResponseBodyApiSummarys ApiSummarys { get; set; }
        public class DescribeApisResponseBodyApiSummarys : TeaModel {
            [NameInMap("ApiSummary")]
            [Validation(Required=false)]
            public List<DescribeApisResponseBodyApiSummarysApiSummary> ApiSummary { get; set; }
            public class DescribeApisResponseBodyApiSummarysApiSummary : TeaModel {
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                [NameInMap("ApiMethod")]
                [Validation(Required=false)]
                public string ApiMethod { get; set; }

                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                [NameInMap("ApiPath")]
                [Validation(Required=false)]
                public string ApiPath { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("DeployedInfos")]
                [Validation(Required=false)]
                public DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfos DeployedInfos { get; set; }
                public class DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfos : TeaModel {
                    [NameInMap("DeployedInfo")]
                    [Validation(Required=false)]
                    public List<DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfosDeployedInfo> DeployedInfo { get; set; }
                    public class DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfosDeployedInfo : TeaModel {
                        [NameInMap("DeployedStatus")]
                        [Validation(Required=false)]
                        public string DeployedStatus { get; set; }

                        [NameInMap("EffectiveVersion")]
                        [Validation(Required=false)]
                        public string EffectiveVersion { get; set; }

                        [NameInMap("StageName")]
                        [Validation(Required=false)]
                        public string StageName { get; set; }

                    }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("TagList")]
                [Validation(Required=false)]
                public DescribeApisResponseBodyApiSummarysApiSummaryTagList TagList { get; set; }
                public class DescribeApisResponseBodyApiSummarysApiSummaryTagList : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeApisResponseBodyApiSummarysApiSummaryTagListTag> Tag { get; set; }
                    public class DescribeApisResponseBodyApiSummarysApiSummaryTagListTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

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
