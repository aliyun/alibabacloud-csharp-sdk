// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeAssetGroupToInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance to query.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/118698.html">DescribeInstanceList</a> operation to query the IDs of all Anti-DDoS Origin instances of paid editions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ddosbgp-cn-7212zaa5v***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The UID of the member to which the asset belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>170858869679****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The ID of the asset. If the asset is a Web Application Firewall (WAF) instance, specify the ID of the WAF instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn-lbj382l****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instance resides.</para>
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
        /// <para>The type of the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>waf</b>: WAF instance</description></item>
        /// <item><description><b>ga</b>: Global Accelerator (GA) instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>waf</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
