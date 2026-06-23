// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpcGrantRulesToEcrResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of authorization rules.</para>
        /// </summary>
        [NameInMap("GrantRuleModels")]
        [Validation(Required=false)]
        public List<DescribeVpcGrantRulesToEcrResponseBodyGrantRuleModels> GrantRuleModels { get; set; }
        public class DescribeVpcGrantRulesToEcrResponseBodyGrantRuleModels : TeaModel {
            /// <summary>
            /// <para>The time when the authorization was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-09T02:14:51Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the Express Connect Router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecr-tz7w3chlaptxr2****</para>
            /// </summary>
            [NameInMap("EcrId")]
            [Validation(Required=false)]
            public string EcrId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account (main account) that owns the Express Connect Router.</para>
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
            /// <para>The ID of the Alibaba Cloud account (main account) that owns the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192745367151****</para>
            /// </summary>
            [NameInMap("InstanceUid")]
            [Validation(Required=false)]
            public long? InstanceUid { get; set; }

            /// <summary>
            /// <para>The ID of the region where the network instance is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The type of the network instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>VBR</b>: virtual border router</para>
            /// </description></item>
            /// <item><description><para><b>VPC</b>: Virtual Private Cloud</para>
            /// </description></item>
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
        /// <para>The pagination token for the next page of results. A non-empty value indicates that more results are available. If this parameter is not returned or is empty, all results have been retrieved.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>NextToken</b> is empty, there are no more queries.</para>
        /// </description></item>
        /// <item><description><para>If <b>NextToken</b> has a value, the value is the token to start the next query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66342E8E-5E87-5FF9-80C7-C3E3571A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries. Note: When you perform a paged query by using the <c>MaxResults</c> and <c>NextToken</c> parameters, the value of this parameter is for reference only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
