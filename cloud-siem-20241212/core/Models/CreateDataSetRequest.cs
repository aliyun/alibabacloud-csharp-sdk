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
        /// <para>The name of the unique key for the dataset.</para>
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
        /// <item><description><para>0: deleted.</para>
        /// </description></item>
        /// <item><description><para>1: enabled.</para>
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
        /// <para>The type of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>custom: custom.</para>
        /// </description></item>
        /// <item><description><para>preset: predefined.</para>
        /// </description></item>
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
            /// <para>The automatic detection status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enabled: enabled.</para>
            /// </description></item>
            /// <item><description><para>disabled: disabled.</para>
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
            /// <para>The type of IP address that the recognizer detects. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>sas_vulnerability_scanner_ip: The IP address of the Security Center web vulnerability scanner.</para>
            /// </description></item>
            /// <item><description><para>waf_back_source_ip: The back-to-origin IP address of Web Application Firewall (WAF).</para>
            /// </description></item>
            /// <item><description><para>ddos_back_source_ip: The back-to-origin IP address of Anti-DDoS.</para>
            /// </description></item>
            /// <item><description><para>esa_back_source_ip: The back-to-origin IP address of an Edge Security Acceleration (ESA) node.</para>
            /// </description></item>
            /// <item><description><para>ecs_public_ip: The public IP address of an Elastic Compute Service (ECS) instance.</para>
            /// </description></item>
            /// <item><description><para>slb_public_ip: The public IP address of a Server Load Balancer (SLB) instance.</para>
            /// </description></item>
            /// <item><description><para>vpc_eip: An Elastic IP Address (EIP).</para>
            /// </description></item>
            /// <item><description><para>cdn_back_source_ip: The back-to-origin IP address of a content delivery network (CDN).</para>
            /// </description></item>
            /// <item><description><para>ga_back_source_ip: The back-to-origin IP address of Global Accelerator (GA).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>waf_back_source_ip</para>
            /// </summary>
            [NameInMap("IpWhitelistRecognizerType")]
            [Validation(Required=false)]
            public string IpWhitelistRecognizerType { get; set; }

            /// <summary>
            /// <para>The detection scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>current_account: the current account only.</para>
            /// </description></item>
            /// <item><description><para>rd_accounts: all accounts in your resource directory.</para>
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
        /// <para>The language of the response. Valid values:</para>
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
        /// <para>The region of the Data Management center for threat analysis. Select a region based on where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are outside China.</para>
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
        /// <para>The user ID of the member whose permissions are used to perform the operation. This parameter is used when an administrator acts on behalf of a member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
