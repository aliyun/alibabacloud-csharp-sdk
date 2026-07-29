// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribePackIpListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Anti-DDoS Origin instance to query.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/118698.html">DescribeInstanceList</a> to query the IDs of all Anti-DDoS Origin instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddosbgp-cn-n6w1r7nz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The protected IP address to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.98.XX.XX</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The UID of the member account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>170858869679****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

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
        /// <para>The number of protected IP addresses to return on each page. The maximum value is 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the cloud asset to which the protected IP address belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ECS</b>: an Elastic Compute Service (ECS) instance.</para>
        /// </description></item>
        /// <item><description><para><b>SLB</b>: a Classic Load Balancer (CLB) instance.</para>
        /// </description></item>
        /// <item><description><para><b>EIP</b>: an Elastic IP Address (EIP) instance. Because Application Load Balancer (ALB) instances use EIPs, query the public IP address of an ALB instance using the EIP.</para>
        /// </description></item>
        /// <item><description><para><b>WAF</b>: a Web Application Firewall (WAF) instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <para>The region ID of the Anti-DDoS Origin instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/118703.html">DescribeRegions</a> to query the IDs of all regions that Anti-DDoS Origin supports.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Origin instance belongs in Resource Management.</para>
        /// <para>If you do not set this parameter, the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceGroupId { get; set; }

    }

}
