// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpcGrantRulesToEcrRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Express Connect Router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-ncxadcujadncsa****</para>
        /// </summary>
        [NameInMap("EcrInstanceId")]
        [Validation(Required=false)]
        public string EcrInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account (main account) that owns the Express Connect Router.</para>
        /// <remarks>
        /// <para>This parameter is required when querying a cross-account network instance.</para>
        /// </remarks>
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
        /// <para>The type of instance whose authorization rules you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VBR</b>: Set the value to <b>VBR</b> to query the Virtual Private Cloud (VPC) instances authorized to connect to the specified virtual border router (VBR).</para>
        /// </description></item>
        /// <item><description><para><b>VPC</b>: Set the value to <b>VPC</b> to query the VBRs to which the specified VPC has granted authorization.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Omit this parameter for the first request.</para>
        /// </description></item>
        /// <item><description><para>For subsequent requests, set this to the <b>NextToken</b> value from the previous response.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the network instance is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the network instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeVpcGrantRulesToEcrRequestTags> Tags { get; set; }
        public class DescribeVpcGrantRulesToEcrRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
