// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeInstanceListRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the Anti-DDoS Origin instances to query. Specify the value is in the <c>[&quot;&lt;Instance ID 1&gt;&quot;,&quot;&lt;Instance ID 2&gt;&quot;,……]</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ddosbgp-cn-oew1pjrk****&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public string InstanceIdList { get; set; }

        /// <summary>
        /// <para>The mitigation plan of the Anti-DDoS Origin instance to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: the Professional mitigation plan</description></item>
        /// <item><description><b>1</b>: the Enterprise mitigation plan</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The mitigation plan of the Anti-DDoS Origin instance.</para>
        /// </summary>
        [NameInMap("InstanceTypeList")]
        [Validation(Required=false)]
        public List<string> InstanceTypeList { get; set; }

        /// <summary>
        /// <para>The IP address of the object that is protected by the Anti-DDoS Origin instance to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.89.XX.XX</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The protocol type of the IP address asset that is protected by the Anti-DDoS Origin instance to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Ipv4</b>: IPv4</description></item>
        /// <item><description><b>Ipv6</b>: IPv6</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The field that is used to sort the Anti-DDoS Origin instances. Set the value to <b>expireTime</b>, which indicates that the instances are sorted based on the expiration time.</para>
        /// <para>You can set the <b>Orderdire</b> parameter to specify the sorting method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>expireTime</para>
        /// </summary>
        [NameInMap("Orderby")]
        [Validation(Required=false)]
        public string Orderby { get; set; }

        /// <summary>
        /// <para>The sorting method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>desc</b>: the descending order. This is the default value.</description></item>
        /// <item><description><b>asc</b>: the ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Orderdire")]
        [Validation(Required=false)]
        public string Orderdire { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Anti-DDoS Origin instance to query resides.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/118703.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The remarks of the Anti-DDoS Origin instance to query. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Origin instance belongs in Resource Management.</para>
        /// <para>If you do not specify this parameter, the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags that are added to the Anti-DDoS Origin instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstanceListRequestTag> Tag { get; set; }
        public class DescribeInstanceListRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag that is added to the Anti-DDoS Origin instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag that is added to the Anti-DDoS Origin instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
