// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class MoveIpRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the destination Anti-DDoS Origin instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/118698.html">DescribeInstanceList</a> operation to query the IDs of all Anti-DDoS Origin instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ddos_originpre_public_cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of IP addresses to migrate to an Anti-DDoS Origin instance for protection. The list is represented as a character string in JSON array format. Each element in the JSON array is a structure that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ip</b>: String type. Required. The IP address to add.</para>
        /// </description></item>
        /// <item><description><para><b>member_uid</b>: String type. Optional. The member accounts to which the asset belongs. This field is required only when you add an asset under member accounts. Example: [{&quot;ip&quot;:&quot;121.41.XX.XX&quot;,&quot;member_uid&quot;:&quot;120100811162****&quot;}]</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ip&quot;:&quot;121.41.XX.XX&quot;},{&quot;ip&quot;:&quot;121.42.XX.XX&quot;}]</para>
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public string IpList { get; set; }

        /// <summary>
        /// <para>The region ID of the Anti-DDoS Origin instance.</para>
        /// <remarks>
        /// <para>You can call the DescribeRegions operation to query all regions supported by Anti-DDoS Origin.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the source Anti-DDoS Origin instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/118698.html">DescribeInstanceList</a> operation to query the IDs of all Anti-DDoS Origin instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ddos_originpre_public_cn-***</para>
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

    }

}
