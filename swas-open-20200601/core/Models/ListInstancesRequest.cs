// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription. Currently, only the subscription billing method is supported.</description></item>
        /// </list>
        /// <para>Default value: PrePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The instance IDs of the simple application servers. The value can be a JSON array that consists of up to 100 instance IDs. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>If you specify both the InstanceIds and PublicIpAddresses parameters, ensure that the specified instance IDs and public IP addresses belong to the same simple application server. Otherwise, an empty response is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;2ad1ae67295445f598017499dc****&quot;, &quot;2ad1ae67295445f598017123dc****&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The name of the simple application server. You can use the asterisk (*) wildcard for fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The page number of the simple application server list.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The plan type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: general-purpose.</description></item>
        /// <item><description>CAPACITY: storage-optimized.</description></item>
        /// <item><description>PREVIOUS: previous generation.</description></item>
        /// <item><description>MULTI_IP: multi-public-IP.</description></item>
        /// <item><description>INTERNATIONAL: international.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2861773.html">Instance families</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

        /// <summary>
        /// <para>The public IP addresses of the simple application servers. The value can be a JSON array that consists of up to 100 public IP addresses. Separate multiple IP addresses with commas (,).</para>
        /// <remarks>
        /// <para>If you specify both the InstanceIds and PublicIpAddresses parameters, ensure that the specified instance IDs and public IP addresses belong to the same simple application server. Otherwise, an empty response is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<c>42.1.**.**</c>&quot;, &quot;<c>42.2.**.**</c>&quot;]</para>
        /// </summary>
        [NameInMap("PublicIpAddresses")]
        [Validation(Required=false)]
        public string PublicIpAddresses { get; set; }

        /// <summary>
        /// <para>The region ID of the simple application server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the simple application server belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2bti7cf7****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending: The instance is being prepared.</description></item>
        /// <item><description>Starting: The instance is starting.</description></item>
        /// <item><description>Running: The instance is running.</description></item>
        /// <item><description>Stopping: The instance is stopping.</description></item>
        /// <item><description>Stopped: The instance is stopped.</description></item>
        /// <item><description>Resetting: The instance is being reset.</description></item>
        /// <item><description>Upgrading: The instance is being upgraded.</description></item>
        /// <item><description>Disabled: The instance is unavailable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListInstancesRequestTag> Tag { get; set; }
        public class ListInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. The tag key must be 1 to 64 characters in length. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. The tag value must be 1 to 64 characters in length. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
