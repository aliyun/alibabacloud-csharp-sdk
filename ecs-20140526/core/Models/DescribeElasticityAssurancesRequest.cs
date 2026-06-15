// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeElasticityAssurancesRequest : TeaModel {
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public DescribeElasticityAssurancesRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class DescribeElasticityAssurancesRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The IDs of the elasticity assurances. You can specify a JSON array of up to 100 elasticity assurance IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;eap-bp67acfmxazb4****&quot;, &quot;eap-bp67acfmxazb5****&quot;]</para>
            /// </summary>
            [NameInMap("Ids")]
            [Validation(Required=false)]
            public string Ids { get; set; }

        }

        /// <summary>
        /// <para>The billing method of the instances. Only <c>PostPaid</c> (pay-as-you-go) is supported.</para>
        /// <para>Default value: <c>PostPaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance type. You can use this parameter to query only active elasticity assurances. To query released elasticity assurances, you must use <c>PrivatePoolOptions.Ids</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
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
        /// <para>The type of the Elasticity Assurance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ElasticityAssurance</c>: a standard elasticity assurance. This type of elasticity assurance is created when you do not specify <c>RecurrenceRules</c>.</para>
        /// </description></item>
        /// <item><description><para><c>TimeDivisionElasticityAssurance</c>: a time-division elasticity assurance. This type of elasticity assurance is created when you specify <c>RecurrenceRules</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ElasticityAssurance</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Elasticity Assurance is located. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. When you use this parameter to filter resources, the number of matching resources cannot exceed 1,000.</para>
        /// <remarks>
        /// <para>Filtering by the default resource group is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
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
        /// <para>The status of the Elasticity Assurance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>All</c>: all statuses.</para>
        /// </description></item>
        /// <item><description><para><c>Deactivated</c>: The Elasticity Assurance is pending activation. This status is available only for invitational preview.</para>
        /// </description></item>
        /// <item><description><para><c>Preparing</c>: The Elasticity Assurance is being prepared.</para>
        /// </description></item>
        /// <item><description><para><c>Prepared</c>: The Elasticity Assurance is ready to take effect.</para>
        /// </description></item>
        /// <item><description><para><c>Active</c>: The Elasticity Assurance is active.</para>
        /// </description></item>
        /// <item><description><para><c>Released</c>: The Elasticity Assurance is released.</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter, elasticity assurances in all states are returned, except for those in the <c>Pending</c> and <c>Released</c> states.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags used to filter Elasticity Assurances.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeElasticityAssurancesRequestTag> Tag { get; set; }
        public class DescribeElasticityAssurancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can specify up to 20 tag keys to filter resources.</para>
            /// <para>The query returns a maximum of 1,000 resources that match the specified tags. If more than 1,000 resources match the tags, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query all the resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can specify up to 20 tag values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the zone where the Elasticity Assurance is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
