// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAndroidInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIds")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIds { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("AndroidInstanceName")]
        [Validation(Required=false)]
        public string AndroidInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the application control rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amp-shigvudbyeuib****</para>
        /// </summary>
        [NameInMap("AppManagePolicyId")]
        [Validation(Required=false)]
        public string AppManagePolicyId { get; set; }

        /// <summary>
        /// <para>The ID of the user assigned to the instance, which is the Wuying convenience user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("AuthorizedUserId")]
        [Validation(Required=false)]
        public string AuthorizedUserId { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The region ID. You can call the <a href="https://help.aliyun.com/document_detail/2807298.html">DescribeRegions</a> operation to query the list of regions where different versions of cloud phones (instance edition and matrix edition) are available for purchase.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;The region ID. You can call the <a href="https://help.aliyun.com/document_detail/2807298.html">DescribeRegions</a> operation to query the list of regions where cloud phones are available for purchase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag-25nt4kk9whjh****</para>
        /// </summary>
        [NameInMap("InstanceGroupId")]
        [Validation(Required=false)]
        public string InstanceGroupId { get; set; }

        /// <summary>
        /// <para>The list of instance group IDs.</para>
        /// </summary>
        [NameInMap("InstanceGroupIds")]
        [Validation(Required=false)]
        public List<string> InstanceGroupIds { get; set; }

        /// <summary>
        /// <para>The name of the instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceGroupName")]
        [Validation(Required=false)]
        public string InstanceGroupName { get; set; }

        /// <summary>
        /// <para>The instance version. Default value: basic, which queries Wuying cloud phone instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EnterpriseAi</para>
        /// </summary>
        [NameInMap("InstanceVersion")]
        [Validation(Required=false)]
        public string InstanceVersion { get; set; }

        /// <summary>
        /// <para>The ID of the associated key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kp-5hh431emkpuoi****</para>
        /// </summary>
        [NameInMap("KeyPairId")]
        [Validation(Required=false)]
        public string KeyPairId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for paging. Valid values: 1 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that specifies the starting position for the next query. An empty value indicates that the query starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kw9dGL5jves2FS9RLq****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The matrix ID.
        /// &lt;props=&quot;intl&quot;&gt;This parameter is not publicly available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node_id</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The name of the matrix.
        /// &lt;props=&quot;intl&quot;&gt;This parameter is not publicly available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node_name</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The ID of the cloud phone network.</para>
        /// </summary>
        [NameInMap("OfficeSiteIds")]
        [Validation(Required=false)]
        public List<string> OfficeSiteIds { get; set; }

        /// <summary>
        /// <para>The private IP address of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.162.136</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The ID of the public network throttling rule group. This specifies the throttling rules for instances in the basic shared network.</para>
        /// </summary>
        [NameInMap("QosRuleIds")]
        [Validation(Required=false)]
        public List<string> QosRuleIds { get; set; }

        /// <summary>
        /// <para>The sale mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("SaleMode")]
        [Validation(Required=false)]
        public string SaleMode { get; set; }

        /// <summary>
        /// <para>The sort key used when querying resources.</para>
        /// <para>This parameter must be used together with SortType. Valid values: CreationTime and ExpiredTime.</para>
        /// <para>If you set this parameter to CreationTime, the resources are sorted by creation time. If you set this parameter to ExpiredTime, the resources are sorted by expiration time.</para>
        /// <para>By default, resources are sorted in descending order of creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime</para>
        /// </summary>
        [NameInMap("SortKey")]
        [Validation(Required=false)]
        public string SortKey { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: DESC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order</description></item>
        /// <item><description>DESC: descending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <para>The instance status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeAndroidInstancesRequestTag> Tag { get; set; }
        public class DescribeAndroidInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
