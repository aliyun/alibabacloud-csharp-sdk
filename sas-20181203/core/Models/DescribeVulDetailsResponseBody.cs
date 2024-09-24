// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the vulnerability.</para>
        /// </summary>
        [NameInMap("Cves")]
        [Validation(Required=false)]
        public List<DescribeVulDetailsResponseBodyCves> Cves { get; set; }
        public class DescribeVulDetailsResponseBodyCves : TeaModel {
            /// <summary>
            /// <para>The type of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remote_code_execution</para>
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// <para>The vulnerability types.</para>
            /// </summary>
            [NameInMap("Classifys")]
            [Validation(Required=false)]
            public List<DescribeVulDetailsResponseBodyCvesClassifys> Classifys { get; set; }
            public class DescribeVulDetailsResponseBodyCvesClassifys : TeaModel {
                /// <summary>
                /// <para>The type of the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>remote_code_execution</para>
                /// </summary>
                [NameInMap("Classify")]
                [Validation(Required=false)]
                public string Classify { get; set; }

                /// <summary>
                /// <para>The URL of the demo video for the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com">https://example.com</a></para>
                /// </summary>
                [NameInMap("DemoVideoUrl")]
                [Validation(Required=false)]
                public string DemoVideoUrl { get; set; }

                /// <summary>
                /// <para>The description of the vulnerability type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Remote code execution</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// <para>The China National Vulnerability Database (CNVD) ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNVD-2019-9167</para>
            /// </summary>
            [NameInMap("CnvdId")]
            [Validation(Required=false)]
            public string CnvdId { get; set; }

            /// <summary>
            /// <para>The difficulty level of exploiting the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>LOW</b></description></item>
            /// <item><description><b>MEDIUM</b></description></item>
            /// <item><description><b>HIGH</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LOW</para>
            /// </summary>
            [NameInMap("Complexity")]
            [Validation(Required=false)]
            public string Complexity { get; set; }

            /// <summary>
            /// <para>The CVE content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Apache Shiro is a user authentication and authorization framework for a wide range of rights management applications.↵Recently, Apache Shiro released version 1.7.0, which fixes the Apache Shiro authentication bypass vulnerability (CVE-2020-17510).↵Attackers can bypass Shiro\&quot;s authentication using malicious requests containing payloads.↵↵Related bugs:↵CVE-2020-17510 Shiro &lt; 1.7.0 Validation Bypass Vulnerability↵CVE-2020-13933 Shiro &lt; 1.6.0 Validation Bypass Vulnerability↵CVE-2020-11989 Shiro &lt; 1.5.3 Validation Bypass Vulnerability↵CVE-2020-1957 Shiro &lt; 1.5.2 Validation Bypass Vulnerability↵CVE-2016-6802 Shiro &lt; 1.3.2 Validation Bypass Vulnerability
            /// Check whether the fastjson version currently running on the system is in the affected version and whether safeMode is configured to disable autoType. If it is in the affected version and safeMode is not configured to disable autoType, the vulnerability is considered to exist.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The Common Vulnerabilities and Exposures (CVE) ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2019-9167</para>
            /// </summary>
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            /// <summary>
            /// <para>The link to the CVE details.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://avd.aliyun.com/detail/CVE-2022-1184">https://avd.aliyun.com/detail/CVE-2022-1184</a></para>
            /// </summary>
            [NameInMap("CveLink")]
            [Validation(Required=false)]
            public string CveLink { get; set; }

            /// <summary>
            /// <para>The Common Vulnerability Scoring System (CVSS) score of the vulnerability in the Alibaba Cloud vulnerability library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0</para>
            /// </summary>
            [NameInMap("CvssScore")]
            [Validation(Required=false)]
            public string CvssScore { get; set; }

            /// <summary>
            /// <para>The vector that is used to calculate the CVSS score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AV:N/AC:L/Au:N/C:C/I:C/A:C</para>
            /// </summary>
            [NameInMap("CvssVector")]
            [Validation(Required=false)]
            public string CvssVector { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// <remarks>
            /// <para> This parameter is deprecated. You can call the <a href="~~DescribeVulList~~">DescribeVulList</a> operation to query the instance that is affected by the vulnerability.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-001</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// <remarks>
            /// <para> This parameter is deprecated. You can call the <a href="~~DescribeVulList~~">DescribeVulList</a> operation to query the instance that is affected by the vulnerability.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>47.114.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// <remarks>
            /// <para> This parameter is deprecated. You can call the <a href="~~DescribeVulList~~">DescribeVulList</a> operation to query the instance that is affected by the vulnerability.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.19.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The ID of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2020-8597</para>
            /// </summary>
            [NameInMap("OtherId")]
            [Validation(Required=false)]
            public string OtherId { get; set; }

            /// <summary>
            /// <para>The POC content.</para>
            /// </summary>
            [NameInMap("Poc")]
            [Validation(Required=false)]
            public string Poc { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp when the proof of concept (POC) was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1554189334000</para>
            /// </summary>
            [NameInMap("PocCreateTime")]
            [Validation(Required=false)]
            public long? PocCreateTime { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp when the POC was disclosed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1554189334000</para>
            /// </summary>
            [NameInMap("PocDisclosureTime")]
            [Validation(Required=false)]
            public long? PocDisclosureTime { get; set; }

            /// <summary>
            /// <para>The service that is affected by the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Log4j2</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The reference of the vulnerability in the Alibaba Cloud vulnerability library. The value is a URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com">https://example.com</a></para>
            /// </summary>
            [NameInMap("Reference")]
            [Validation(Required=false)]
            public string Reference { get; set; }

            /// <summary>
            /// <para>The disclosure time that is displayed for the vulnerability in the Alibaba Cloud vulnerability library. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1554189334000</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <para>The fixing suggestions of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>At present, Chanjet has urgently released a vulnerability patch to fix the vulnerability. CNVD recommends affected units and users to upgrade to the latest version immediately:</para>↵<para>https://www.chanjetvip.com/product/goods/goods-detail?id=53aaa40295d458e44f5d3ce5</para>↵<para>At the same time, organizations and users affected by the vulnerability are requested to immediately follow the steps below to conduct self-inspection and repair work:</para>↵<ol>↵<item><description><para>User self-check steps:↵<br  />Check whether website/bin/load.aspx.cdcab7d2.compiled, website/bin/App_Web_load.aspx.cdcab7d2.dll, and tplus/Load.aspx files exist locally. If they exist, it means that they have been poisoned, and you must reinstall the system and install the product. patch.</para>↵</description></item>↵<item><description><para>Non-poisoned users please:↵<br  />1) Update the latest product patch.↵<br  />2) Install anti-virus software and update the virus database in time.↵<br  />3) Upgrade the lower version of IIS and Nginx to IIS10.0 and Windows 2016.↵<br  />4) Local installation customers need to confirm whether the backup file is complete as soon as possible, and do off-site backup. Customers on the cloud should enable the mirroring function in time.↵<br  />5) Users who fail to update the patch in time can contact Chanjet technical support and take temporary preventive measures such as deleting files.</para>↵</description></item>↵<item><description><para>Poisoned users please:↵<br  />1) Check whether the server has taken regular snapshots or backups. If so, you can restore data through snapshots or backups.↵<br  />2) Contact Chanjet technical support to confirm whether it has the conditions and operation methods to restore data from backup files.</para>↵</description></item>↵</ol>↵<para>If you have any technical problems, please contact Chanjet technical support: 4006600566-9</para>
            /// </summary>
            [NameInMap("Solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

            /// <summary>
            /// <para>The introduction to the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Chanjet T-Plus is an Internet business management software. There is an unauthorized access vulnerability in one of its interfaces disclosed on the Internet. Attackers can construct malicious requests to upload malicious files to execute arbitrary code and control the server.</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The ID of the asset that is scanned.</para>
            /// <remarks>
            /// <para> This parameter is deprecated. You can call the <a href="~~DescribeVulList~~">DescribeVulList</a> operation to query the instance that is affected by the vulnerability.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>m-bp17m0pc0xprzbwo****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The name of the asset that is scanned.</para>
            /// <remarks>
            /// <para> This parameter is deprecated. You can call the <a href="~~DescribeVulList~~">DescribeVulList</a> operation to query the instance that is affected by the vulnerability.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>frontend</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The title of the vulnerability announcement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Chanjet T-Plus SetupAccount/Upload. Aspx file upload vulnerability(CNVD-2022-60632)</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The vendor that disclosed the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Apache</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

            /// <summary>
            /// <para>The severity of the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>serious</b></description></item>
            /// <item><description><b>high</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>low</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>serious</para>
            /// </summary>
            [NameInMap("VulLevel")]
            [Validation(Required=false)]
            public string VulLevel { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDA40EA3-6265-5900-AD99-C83E4F109CA8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
