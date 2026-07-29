// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ModifyRemarkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Anti-DDoS Origin instance for which you want to set a remark.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/118698.html">DescribeInstanceList</a> to query the IDs of all Anti-DDoS Origin instances.</para>
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
        /// <para>The region ID of the Anti-DDoS Origin instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/118703.html">DescribeRegions</a> to query all region IDs supported by Anti-DDoS Origin.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The remark for the Anti-DDoS Origin instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-remark</para>
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

    }

}
