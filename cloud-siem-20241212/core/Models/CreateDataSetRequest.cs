// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateDataSetRequest : TeaModel {
        /// <summary>
        /// <para>The description of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lmftest contains ip list</para>
        /// </summary>
        [NameInMap("DataSetDescription")]
        [Validation(Required=false)]
        public string DataSetDescription { get; set; }

        /// <summary>
        /// <para>The unique key name of the dataset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("DataSetFieldKeyName")]
        [Validation(Required=false)]
        public string DataSetFieldKeyName { get; set; }

        /// <summary>
        /// <para>The name of the uploaded dataset file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudsiem-dataset/1358117679873357_17433*****.csv</para>
        /// </summary>
        [NameInMap("DataSetFileName")]
        [Validation(Required=false)]
        public string DataSetFileName { get; set; }

        /// <summary>
        /// <para>The name of the dataset.</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description>0: Deleted.</description></item>
        /// <item><description>1: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataSetStatus")]
        [Validation(Required=false)]
        public int? DataSetStatus { get; set; }

        /// <summary>
        /// <para>The type of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>custom: custom.</description></item>
        /// <item><description>preset: predefined.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("DataSetType")]
        [Validation(Required=false)]
        public string DataSetType { get; set; }

        /// <summary>
        /// <para>The list of recognizers.</para>
        /// </summary>
        [NameInMap("IpWhitelistRecognizers")]
        [Validation(Required=false)]
        public List<CreateDataSetRequestIpWhitelistRecognizers> IpWhitelistRecognizers { get; set; }
        public class CreateDataSetRequestIpWhitelistRecognizers : TeaModel {
            /// <summary>
            /// <para>The automatic recognition status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled.</description></item>
            /// <item><description>disabled: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AutoRecognizeStatus")]
            [Validation(Required=false)]
            public string AutoRecognizeStatus { get; set; }

            /// <summary>
            /// <para>The IP address type identified by the recognizer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>sas_vulnerability_scanner_ip: IP addresses of the Security Center vulnerability web scanner.</description></item>
            /// <item><description>waf_back_source_ip: back-to-origin IP addresses of Web Application Firewall (WAF).</description></item>
            /// <item><description>ddos_back_source_ip: back-to-origin IP addresses of Anti-DDoS.</description></item>
            /// <item><description>esa_back_source_ip: back-to-origin node IP addresses of Edge secure acceleration (ESA).</description></item>
            /// <item><description>ecs_public_ip: public IP addresses of Elastic Compute Service (ECS) instances.</description></item>
            /// <item><description>slb_public_ip: public IP addresses of Server Load Balancer (SLB) instances.</description></item>
            /// <item><description>vpc_eip: elastic IP addresses (EIPs).</description></item>
            /// <item><description>cdn_back_source_ip: back-to-origin IP addresses of content delivery network (CDN).</description></item>
            /// <item><description>ga_back_source_ip: back-to-origin IP addresses of Global Accelerator (GA).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>waf_back_source_ip</para>
            /// </summary>
            [NameInMap("IpWhitelistRecognizerType")]
            [Validation(Required=false)]
            public string IpWhitelistRecognizerType { get; set; }

            /// <summary>
            /// <para>The recognition scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>current_account: the current account only.</description></item>
            /// <item><description>rd_accounts: multi-account mode enabled.</description></item>
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
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.
        /// Note: This parameter is required. If you do not specify this parameter, the API returns a 400 error: &quot;The specified Lang can not be empty.&quot;</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The region where the threat analysis data management center resides. Specify the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member to which the administrator switches the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
