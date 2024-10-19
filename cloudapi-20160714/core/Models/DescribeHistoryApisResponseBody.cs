// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeHistoryApisResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned API information. It is an array consisting of ApiHisItems.</para>
        /// </summary>
        [NameInMap("ApiHisItems")]
        [Validation(Required=false)]
        public DescribeHistoryApisResponseBodyApiHisItems ApiHisItems { get; set; }
        public class DescribeHistoryApisResponseBodyApiHisItems : TeaModel {
            [NameInMap("ApiHisItem")]
            [Validation(Required=false)]
            public List<DescribeHistoryApisResponseBodyApiHisItemsApiHisItem> ApiHisItem { get; set; }
            public class DescribeHistoryApisResponseBodyApiHisItemsApiHisItem : TeaModel {
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
                /// <para>The API name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v2_role_assign</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The time when the API was published. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-07-20T08:28:48Z</para>
                /// </summary>
                [NameInMap("DeployedTime")]
                [Validation(Required=false)]
                public string DeployedTime { get; set; }

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
                /// <para>The historical version of the API definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20210915101416294</para>
                /// </summary>
                [NameInMap("HistoryVersion")]
                [Validation(Required=false)]
                public string HistoryVersion { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
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
                /// <para>The environment name. Valid values:</para>
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
                /// <para>Indicates whether an API version is effective. Valid values: ONLINE and OFFLINE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ONLINE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
        /// <para>The number of entries to return on each page. Maximum value: 50. Default value: 10.</para>
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
        /// <para>6C87A26A-6A18-4B8E-8099-705278381A2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
