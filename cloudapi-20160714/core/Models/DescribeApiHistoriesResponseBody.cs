// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiHistoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned API information. It is an array consisting of ApiHisItem data.</para>
        /// </summary>
        [NameInMap("ApiHisItems")]
        [Validation(Required=false)]
        public DescribeApiHistoriesResponseBodyApiHisItems ApiHisItems { get; set; }
        public class DescribeApiHistoriesResponseBodyApiHisItems : TeaModel {
            [NameInMap("ApiHisItem")]
            [Validation(Required=false)]
            public List<DescribeApiHistoriesResponseBodyApiHisItemsApiHisItem> ApiHisItem { get; set; }
            public class DescribeApiHistoriesResponseBodyApiHisItemsApiHisItem : TeaModel {
                /// <summary>
                /// <para>The ID of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5af418828f0344a3b588c0cc1331a3bc</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <para>The name of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CreateObject</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The publishing time (UTC) of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-07-20T08:28:48Z</para>
                /// </summary>
                [NameInMap("DeployedTime")]
                [Validation(Required=false)]
                public string DeployedTime { get; set; }

                /// <summary>
                /// <para>The description of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Creates an object</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1084f9034c744137901057206b39d2b6</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myGroup2</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The historical version of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20160705104552393</para>
                /// </summary>
                [NameInMap("HistoryVersion")]
                [Validation(Required=false)]
                public string HistoryVersion { get; set; }

                /// <summary>
                /// <para>The region in which the API is located.</para>
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
                /// <para>Indicates whether an API version is effective. Valid values: <b>ONLINE</b> and <b>OFFLINE</b>.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ003</para>
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
