// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeInstanceListRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the Anti-DDoS Origin instances to query. Specify the value in the <c>[&quot;&lt;Instance ID 1&gt;&quot;,&quot;&lt;Instance ID 2&gt;&quot;,……]</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ddosbgp-cn-oew1pjrk****&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public string InstanceIdList { get; set; }

        /// <summary>
        /// <para>The mitigation plan type of the Anti-DDoS Origin instance to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Professional.</description></item>
        /// <item><description><b>1</b>: Enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The mitigation plan types of the Anti-DDoS Origin instances to query.</para>
        /// </summary>
        [NameInMap("InstanceTypeList")]
        [Validation(Required=false)]
        public List<string> InstanceTypeList { get; set; }

        /// <summary>
        /// <para>The protected IP address of the Anti-DDoS Origin instance to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.89.XX.XX</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The protocol type of the IP assets protected by the Anti-DDoS Origin instance to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b>: IPv4 protocol.</description></item>
        /// <item><description><b>IPv6</b>: IPv6 protocol.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The sort field for the Anti-DDoS Origin instance list. The value is fixed as <b>expireTime</b>, which indicates sorting by instance expiration time.</para>
        /// <para>You can use the <b>Orderdire</b> parameter to specify the sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>expireTime</para>
        /// </summary>
        [NameInMap("Orderby")]
        [Validation(Required=false)]
        public string Orderby { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>desc</b> (default): descending order by expiration time.</description></item>
        /// <item><description><b>asc</b>: ascending order by expiration time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Orderdire")]
        [Validation(Required=false)]
        public string Orderdire { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paging query. Settings the current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of instances on each page in a paging query. Settings the number of instances per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the Anti-DDoS Origin instance to query.</para>
        /// <remarks>
        /// <h2>You can call <a href="https://help.aliyun.com/document_detail/118703.html">DescribeRegions</a> to query all region IDs supported by Anti-DDoS Origin.</h2>
        /// <para>Notice: This parameter is required. If it is not specified, the API returns DDosBgp.CheckError.InvalidRegion(400).</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The remark of the Anti-DDoS Origin instance to query. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Origin instance belongs in Resource Management.</para>
        /// <para>If you do not specify this parameter, the default resource group is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags bound to the Anti-DDoS Origin instances to query.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstanceListRequestTag> Tag { get; set; }
        public class DescribeInstanceListRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag bound to the Anti-DDoS Origin instance to query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag bound to the Anti-DDoS Origin instance to query.</para>
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
