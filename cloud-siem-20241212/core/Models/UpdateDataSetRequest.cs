// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataSetRequest : TeaModel {
        /// <summary>
        /// <para>The description of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lmftest desc</para>
        /// </summary>
        [NameInMap("DataSetDescription")]
        [Validation(Required=false)]
        public string DataSetDescription { get; set; }

        /// <summary>
        /// <para>The name of the uploaded dataset file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudsiem-dataset/1358117679873357_1743387731614.csv</para>
        /// </summary>
        [NameInMap("DataSetFileName")]
        [Validation(Required=false)]
        public string DataSetFileName { get; set; }

        /// <summary>
        /// <para>The ID of the dataset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset-10iy8mbifnb4gniv****</para>
        /// </summary>
        [NameInMap("DataSetId")]
        [Validation(Required=false)]
        public string DataSetId { get; set; }

        /// <summary>
        /// <para>The name of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lmftest</para>
        /// </summary>
        [NameInMap("DataSetName")]
        [Validation(Required=false)]
        public string DataSetName { get; set; }

        /// <summary>
        /// <para>The status of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Delete.</para>
        /// </description></item>
        /// <item><description><para>1: Enable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataSetStatus")]
        [Validation(Required=false)]
        public int? DataSetStatus { get; set; }

        /// <summary>
        /// <para>The IP address types that the recognizer can detect.</para>
        /// </summary>
        [NameInMap("IpWhitelistRecognizers")]
        [Validation(Required=false)]
        public List<UpdateDataSetRequestIpWhitelistRecognizers> IpWhitelistRecognizers { get; set; }
        public class UpdateDataSetRequestIpWhitelistRecognizers : TeaModel {
            /// <summary>
            /// <para>The automatic detection status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enabled: Enabled.</para>
            /// </description></item>
            /// <item><description><para>disabled: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AutoRecognizeStatus")]
            [Validation(Required=false)]
            public string AutoRecognizeStatus { get; set; }

            /// <summary>
            /// <para>The IP address type that the recognizer can detect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>sas_vulnerability_scanner_ip: The IP addresses of the Security Center web vulnerability scanner.</para>
            /// </description></item>
            /// <item><description><para>waf_back_source_ip: The back-to-origin IP addresses of Web Application Firewall (WAF).</para>
            /// </description></item>
            /// <item><description><para>ddos_back_source_ip: The back-to-origin IP addresses of Anti-DDoS.</para>
            /// </description></item>
            /// <item><description><para>esa_back_source_ip: The back-to-origin IP addresses of Edge Security Acceleration (ESA) nodes.</para>
            /// </description></item>
            /// <item><description><para>ecs_public_ip: The public IP addresses of Elastic Compute Service (ECS) instances.</para>
            /// </description></item>
            /// <item><description><para>slb_public_ip: The public IP addresses of Server Load Balancer (SLB).</para>
            /// </description></item>
            /// <item><description><para>vpc_eip: The elastic IP addresses (EIPs).</para>
            /// </description></item>
            /// <item><description><para>cdn_back_source_ip: The back-to-origin IP addresses of Alibaba Cloud CDN.</para>
            /// </description></item>
            /// <item><description><para>ga_back_source_ip: The back-to-origin IP addresses of Global Accelerator (GA).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cdn_back_source_ip</para>
            /// </summary>
            [NameInMap("IpWhitelistRecognizerType")]
            [Validation(Required=false)]
            public string IpWhitelistRecognizerType { get; set; }

            /// <summary>
            /// <para>The detection scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>current_account: The current account only.</para>
            /// </description></item>
            /// <item><description><para>rd_accounts: Multiple accounts are enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>current_account</para>
            /// </summary>
            [NameInMap("RecognizeScope")]
            [Validation(Required=false)]
            public string RecognizeScope { get; set; }

        }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The region where the Data Management center for threat analysis is located. Select a region based on the location of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Assets are in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Assets are in a region outside China.</para>
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
        /// <para>The user ID of a member. An administrator can use this parameter to switch to the member\&quot;s view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
