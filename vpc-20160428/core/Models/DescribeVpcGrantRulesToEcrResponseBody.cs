// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpcGrantRulesToEcrResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorization information.</para>
        /// </summary>
        [NameInMap("GrantRuleModels")]
        [Validation(Required=false)]
        public List<DescribeVpcGrantRulesToEcrResponseBodyGrantRuleModels> GrantRuleModels { get; set; }
        public class DescribeVpcGrantRulesToEcrResponseBodyGrantRuleModels : TeaModel {
            /// <summary>
            /// <para>The creation time in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-09T02:14:51Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ECR ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecr-tz7w3chlaptxr2****</para>
            /// </summary>
            [NameInMap("EcrId")]
            [Validation(Required=false)]
            public string EcrId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the ECR belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192732132151****</para>
            /// </summary>
            [NameInMap("EcrOwnerId")]
            [Validation(Required=false)]
            public long? EcrOwnerId { get; set; }

            /// <summary>
            /// <para>The ID of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz9ek66wd7tl5xqpy****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192745367151****</para>
            /// </summary>
            [NameInMap("InstanceUid")]
            [Validation(Required=false)]
            public long? InstanceUid { get; set; }

            /// <summary>
            /// <para>The ID of the region where the instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The type of instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VBR</b>: queries the permissions that are granted to a VBR.</description></item>
            /// <item><description><b>VPC</b>: queries the permissions that are granted from a VPC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, there is no next page.</description></item>
        /// </list>
        /// <hr>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique ID that Alibaba Cloud generates for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66342E8E-5E87-5FF9-80C7-C3E3571A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances queried. If you specify the MaxResults and NextToken request parameters to perform a paged query, the value of the TotalCount response parameter is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
