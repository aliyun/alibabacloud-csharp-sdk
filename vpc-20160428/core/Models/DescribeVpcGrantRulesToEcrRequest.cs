// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpcGrantRulesToEcrRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ECR that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-ncxadcujadncsa****</para>
        /// </summary>
        [NameInMap("EcrInstanceId")]
        [Validation(Required=false)]
        public string EcrInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the ECR belongs.</para>
        /// <remarks>
        /// <para>If you want to connect to a network instance that belongs to a different account, this parameter is required.</para>
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
        /// <para>The type of instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VBR</b>: queries the permissions that are granted to a VBR.</description></item>
        /// <item><description><b>VPC</b>: queries the permissions that are granted from a VPC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request.</description></item>
        /// <item><description>If a value is returned for NextToken, you must specify the token that is obtained from the previous query as the value of <b>NextToken</b>.</description></item>
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
        /// <para>The region ID of the network instance that you want to query.</para>
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
        /// <para>The tag.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeVpcGrantRulesToEcrRequestTags> Tags { get; set; }
        public class DescribeVpcGrantRulesToEcrRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag. You must specify at least one tag key and at most 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with <c>acs:</c> or <c>aliyun</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. You can enter a maximum of 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
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
