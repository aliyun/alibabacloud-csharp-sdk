// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class OpenDeliveryRequest : TeaModel {
        /// <summary>
        /// <para>The code for a specific log of the cloud service, such as the process log of Security Center. This parameter is optional. If you do not specify this parameter, the operation applies to all logs of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_siem_cfw_flow</para>
        /// </summary>
        [NameInMap("LogCode")]
        [Validation(Required=false)]
        public string LogCode { get; set; }

        /// <summary>
        /// <para>The code of the cloud service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>qcloud_waf</para>
        /// </description></item>
        /// <item><description><para>qcloud_cfw</para>
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
        /// <para>cfw</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The region where the Data Management center of threat analysis is located. Select a region based on the location of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Select this value if your assets are in the Chinese mainland or China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Select this value if your assets are in a region outside China.</para>
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
        /// <para>The ID of the member account that the administrator wants to access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The type of the view. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: The view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: The view of all accounts within the enterprise.</para>
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
