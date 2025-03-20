// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The billing method of the simple application servers. Set the value to PrePaid, which indicates the subscription billing method.</para>
        /// <para>Default value: PrePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The IDs of the simple application servers. The value can be a JSON array that consists of up to 100 simple application server IDs. Separate multiple server IDs with commas (,).</para>
        /// <remarks>
        /// <para>If you specify both <c>InstanceIds</c> and <c>PublicIpAddresses</c>, make sure that the specified IDs and the specified public IP addresses belong to the same simple application servers. Otherwise, an empty result is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;2ad1ae67295445f598017499dc****&quot;, &quot;2ad1ae67295445f598017123dc****&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The name of the simple application server. Fuzzy search with the asterisk (\*) wildcard is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

        /// <summary>
        /// <para>The public IP addresses of the simple application servers. The value can be a JSON array that consists of up to 100 IP addresses. Separate multiple IP addresses with commas (,).</para>
        /// <remarks>
        /// <para>If you specify both <c>InstanceIds</c> and <c>PublicIpAddresses</c>, make sure that the specified IDs and the specified public IP addresses belong to the same simple application servers. Otherwise, an empty result is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<c>42.1.**.**</c>&quot;, &quot;<c>42.2.**.**</c>&quot;]</para>
        /// </summary>
        [NameInMap("PublicIpAddresses")]
        [Validation(Required=false)]
        public string PublicIpAddresses { get; set; }

        /// <summary>
        /// <para>The region ID of the simple application servers.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the simple application servers belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2bti7cf7****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the simple application servers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending</description></item>
        /// <item><description>Starting</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Stopping</description></item>
        /// <item><description>Stopped</description></item>
        /// <item><description>Resetting</description></item>
        /// <item><description>Upgrading</description></item>
        /// <item><description>Disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags that are added to the simple application servers.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListInstancesRequestTag> Tag { get; set; }
        public class ListInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the simple application servers. A tag key can be 1 to 64 characters in length. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the simple application servers. A tag value can be 1 to 64 characters in length. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
