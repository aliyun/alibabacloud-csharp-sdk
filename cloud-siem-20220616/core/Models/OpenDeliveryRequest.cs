// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class OpenDeliveryRequest : TeaModel {
        /// <summary>
        /// <para>The log code of the cloud service, such as the code of the process log for Security Center. This parameter is optional. If you leave this parameter empty, operations are performed on all logs of the cloud service.</para>
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
        /// <item><description>qcloud_waf</description></item>
        /// <item><description>qlcoud_cfw</description></item>
        /// <item><description>hcloud_waf</description></item>
        /// <item><description>hcloud_cfw</description></item>
        /// <item><description>ddos</description></item>
        /// <item><description>sas</description></item>
        /// <item><description>cfw</description></item>
        /// <item><description>config</description></item>
        /// <item><description>csk</description></item>
        /// <item><description>fc</description></item>
        /// <item><description>rds</description></item>
        /// <item><description>nas</description></item>
        /// <item><description>apigateway</description></item>
        /// <item><description>cdn</description></item>
        /// <item><description>mongodb</description></item>
        /// <item><description>eip</description></item>
        /// <item><description>slb</description></item>
        /// <item><description>vpc</description></item>
        /// <item><description>actiontrail</description></item>
        /// <item><description>waf</description></item>
        /// <item><description>bastionhost</description></item>
        /// <item><description>oss</description></item>
        /// <item><description>polardb</description></item>
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
        /// <para>The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in regions in China.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside in regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the account that you switch from the management account.</para>
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
        /// <item><description>0: the current Alibaba Cloud account</description></item>
        /// <item><description>1: the global account</description></item>
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
