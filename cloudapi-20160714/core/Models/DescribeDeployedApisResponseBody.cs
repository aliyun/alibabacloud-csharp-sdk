// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDeployedApisResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned API information. It is an array consisting of DeployedApiItem data.</para>
        /// </summary>
        [NameInMap("DeployedApis")]
        [Validation(Required=false)]
        public DescribeDeployedApisResponseBodyDeployedApis DeployedApis { get; set; }
        public class DescribeDeployedApisResponseBodyDeployedApis : TeaModel {
            [NameInMap("DeployedApiItem")]
            [Validation(Required=false)]
            public List<DescribeDeployedApisResponseBodyDeployedApisDeployedApiItem> DeployedApiItem { get; set; }
            public class DescribeDeployedApisResponseBodyDeployedApisDeployedApiItem : TeaModel {
                /// <summary>
                /// <para>The ID of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c076144d7878437b8f82fb85890ce6a0</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>POST</para>
                /// </summary>
                [NameInMap("ApiMethod")]
                [Validation(Required=false)]
                public string ApiMethod { get; set; }

                /// <summary>
                /// <para>The name of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DescribeObjects</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/trademark/search</para>
                /// </summary>
                [NameInMap("ApiPath")]
                [Validation(Required=false)]
                public string ApiPath { get; set; }

                /// <summary>
                /// <para>The publising time (UTC) of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-07-23T08:28:48Z</para>
                /// </summary>
                [NameInMap("DeployedTime")]
                [Validation(Required=false)]
                public string DeployedTime { get; set; }

                /// <summary>
                /// <para>The description of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Queries objects by pages</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>63be9002440b4778a61122f14c2b2bbb</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the group to which the API belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myGroup3</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The region where the API is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the runtime environment. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>RELEASE</b></description></item>
                /// <item><description><b>TEST</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RELEASE</para>
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

                /// <summary>
                /// <para>Indicates whether the API is public. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PUBLIC</b></description></item>
                /// <item><description><b>PRIVATE</b></description></item>
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
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ002</para>
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
