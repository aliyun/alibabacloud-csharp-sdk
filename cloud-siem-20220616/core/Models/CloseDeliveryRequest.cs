// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class CloseDeliveryRequest : TeaModel {
        /// <summary>
        /// <para>The code of the log within the cloud service. For example, the process log of Security Center. For valid values, see the return value of the ListDelivery operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_siem_aegis_proc</para>
        /// </summary>
        [NameInMap("LogCode")]
        [Validation(Required=false)]
        public string LogCode { get; set; }

        /// <summary>
        /// <para>The code of the cloud service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>qcloud_waf</para>
        /// </description></item>
        /// <item><description><para>qlcoud_cfw</para>
        /// </description></item>
        /// <item><description><para>hcloud_waf</para>
        /// </description></item>
        /// <item><description><para>hcloud_cfw</para>
        /// </description></item>
        /// <item><description><para>ddos</para>
        /// </description></item>
        /// <item><description><para>sas</para>
        /// </description></item>
        /// <item><description><para>cfw</para>
        /// </description></item>
        /// <item><description><para>config</para>
        /// </description></item>
        /// <item><description><para>csk</para>
        /// </description></item>
        /// <item><description><para>fc</para>
        /// </description></item>
        /// <item><description><para>rds</para>
        /// </description></item>
        /// <item><description><para>nas</para>
        /// </description></item>
        /// <item><description><para>apigateway</para>
        /// </description></item>
        /// <item><description><para>cdn</para>
        /// </description></item>
        /// <item><description><para>mongodb</para>
        /// </description></item>
        /// <item><description><para>eip</para>
        /// </description></item>
        /// <item><description><para>slb</para>
        /// </description></item>
        /// <item><description><para>vpc</para>
        /// </description></item>
        /// <item><description><para>actiontrail</para>
        /// </description></item>
        /// <item><description><para>waf</para>
        /// </description></item>
        /// <item><description><para>bastionhost</para>
        /// </description></item>
        /// <item><description><para>oss</para>
        /// </description></item>
        /// <item><description><para>polardb</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The region where the data management center of threat analysis is located. Select a region based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Select this region if your assets are in the Chinese mainland or Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Select this region if your assets are outside China.</para>
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
        /// <para>The user ID of a member. An administrator can use this parameter to switch to the perspective of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type.</para>
        /// <list type="bullet">
        /// <item><description><para>0: The view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: The view of all accounts in your enterprise.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
