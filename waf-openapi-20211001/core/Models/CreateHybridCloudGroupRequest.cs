// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateHybridCloudGroupRequest : TeaModel {
        /// <summary>
        /// <para>The back-to-origin mark of the node group. The value is in the format of Carrier-Continent-City, which is used to identify the origin of back-to-origin requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-asiapacific-beijing</para>
        /// </summary>
        [NameInMap("BackSourceMark")]
        [Validation(Required=false)]
        public string BackSourceMark { get; set; }

        /// <summary>
        /// <para>The ID of the Hybrid Cloud WAF cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the node group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The type of the node group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>protect</b>: a protection node group that processes traffic filtering.</para>
        /// </description></item>
        /// <item><description><para><b>control</b>: a control node group that manages cluster configurations.</para>
        /// </description></item>
        /// <item><description><para><b>storage</b>: a storage node group that stores logs and data.</para>
        /// </description></item>
        /// <item><description><para><b>controlStorage</b>: a node group that serves as both control and storage.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>protect</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf-cn-n6w***x52m</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP address of the load balancer that is associated with the node group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.3.3.3</para>
        /// </summary>
        [NameInMap("LoadBalanceIp")]
        [Validation(Required=false)]
        public string LoadBalanceIp { get; set; }

        /// <summary>
        /// <para>The location code of the region where the node group resides. The value is in the format of Carrier-Continent-City.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0-410-0</para>
        /// </summary>
        [NameInMap("LocationCode")]
        [Validation(Required=false)]
        public string LocationCode { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The remarks on the node group. You can use this parameter to add a brief description for the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}
