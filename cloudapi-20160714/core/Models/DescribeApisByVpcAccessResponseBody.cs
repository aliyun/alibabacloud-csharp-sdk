// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisByVpcAccessResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned API information. It is an array consisting of ApiInfo data.</para>
        /// </summary>
        [NameInMap("ApiVpcAccessInfos")]
        [Validation(Required=false)]
        public DescribeApisByVpcAccessResponseBodyApiVpcAccessInfos ApiVpcAccessInfos { get; set; }
        public class DescribeApisByVpcAccessResponseBodyApiVpcAccessInfos : TeaModel {
            [NameInMap("ApiVpcAccessInfo")]
            [Validation(Required=false)]
            public List<DescribeApisByVpcAccessResponseBodyApiVpcAccessInfosApiVpcAccessInfo> ApiVpcAccessInfo { get; set; }
            public class DescribeApisByVpcAccessResponseBodyApiVpcAccessInfosApiVpcAccessInfo : TeaModel {
                /// <summary>
                /// <para>The API ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>09839002de484e76b5a213b040a6a3ca</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <para>The API name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iwc</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The description, which can be up to 200 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the API group to which the API belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>41c33748cbfb41f6b00870156203b72a</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the API group to which the API belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RT_PLU_IP_CTRL_group</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The instance ID or IP address in the VPC access authorization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ib-04e41XXXXXd95e9c1</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The HTTP request method of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>POST</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The request path of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/api/v1/friends/rc/status</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>443</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

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
                /// <para>The environment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>57e17906a69b4424914fb1e05f67c78a</para>
                /// </summary>
                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                /// <summary>
                /// <para>The environment to which the API is published. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>RELEASE</b>: the production environment</description></item>
                /// <item><description><b>PRE</b>: the staging environment</description></item>
                /// <item><description><b>TEST</b>: the test environment</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RELEASE</para>
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

                /// <summary>
                /// <para>vpc id</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2ze7bj64wstznvftrskbk</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The name of the VPC access authorization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliYun_service_prod</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
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
        /// <para>4E707B25-5119-5ACF-9D26-7D2A2762F05C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
