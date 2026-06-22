// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportRecordRequest : TeaModel {
        /// <summary>
        /// <para>The type of file to export. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>virusScanExport</b>: Exports details of a virus scan task. This parameter is required when ExportType is set to virusScanExport.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>virusScanExport</para>
        /// </summary>
        [NameInMap("ExportFileType")]
        [Validation(Required=false)]
        public string ExportFileType { get; set; }

        /// <summary>
        /// <para>The type of records to export. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>assetInstance</b>: The list of servers in Asset Center</para>
        /// </description></item>
        /// <item><description><para><b>user</b>: The list of account asset fingerprints</para>
        /// </description></item>
        /// <item><description><para><b>port</b>: The list of port asset fingerprints</para>
        /// </description></item>
        /// <item><description><para><b>process</b>: The list of process asset fingerprints</para>
        /// </description></item>
        /// <item><description><para><b>sca</b>: The list of middleware asset fingerprints</para>
        /// </description></item>
        /// <item><description><para><b>database</b>: The list of database asset fingerprints</para>
        /// </description></item>
        /// <item><description><para><b>web</b>: The list of web service asset fingerprints</para>
        /// </description></item>
        /// <item><description><para><b>software</b>: The list of software asset fingerprints</para>
        /// </description></item>
        /// <item><description><para><b>cron</b>: The list of scheduled task (cron) asset fingerprints</para>
        /// </description></item>
        /// <item><description><para><b>autorun</b>: The list of startup item asset fingerprints</para>
        /// </description></item>
        /// <item><description><para><b>lkm</b>: The list of kernel module asset fingerprints</para>
        /// </description></item>
        /// <item><description><para><b>webserver</b>: The list of website asset fingerprints</para>
        /// </description></item>
        /// <item><description><para><b>virusScanExport</b>: The list of virus scan task details</para>
        /// </description></item>
        /// <item><description><para><b>imageVulExport</b>: The list of system vulnerabilities in images</para>
        /// </description></item>
        /// <item><description><para>imageVulExport: The list of system vulnerabilities in images</para>
        /// </description></item>
        /// <item><description><para><b>imageBaseLineExport</b>: The list of image baseline check results</para>
        /// </description></item>
        /// <item><description><para><b>imageAffectedMaliciousExport</b>: The list of malicious sample check results for images</para>
        /// </description></item>
        /// <item><description><para><b>baselineCspm</b>: The list of cloud platform configuration check results</para>
        /// </description></item>
        /// <item><description><para><b>attack</b>: The list of attack analysis alerts</para>
        /// </description></item>
        /// <item><description><para><b>accessKey</b>: The list of AK leakage detection alerts</para>
        /// </description></item>
        /// <item><description><para><b>exportObjectScanEvents</b>: The list of malicious file detection alerts</para>
        /// </description></item>
        /// <item><description><para><b>domainDetail</b>: Website assets</para>
        /// </description></item>
        /// <item><description><para><b>assetsPropertyScaProcessDetail</b>: RASP-protected processes</para>
        /// </description></item>
        /// <item><description><para><b>exportHcWarning</b>: The list of system baseline risks</para>
        /// </description></item>
        /// <item><description><para><b>raspAttackAlert</b>: The list of RASP attack alerts</para>
        /// </description></item>
        /// <item><description><para><b>raspApplicationConfiguration</b>: The list of RASP application configurations</para>
        /// </description></item>
        /// <item><description><para><b>raspWeaknessDetection</b>: The list of RASP weakness detection results</para>
        /// </description></item>
        /// <item><description><para><b>raspInMemoryWebshellDetection</b>: The list of RASP alerts for in-memory webshell detection</para>
        /// </description></item>
        /// <item><description><para><b>raspInMemoryWebshellInsertion</b>: The list of RASP alerts for in-memory webshell insertion</para>
        /// </description></item>
        /// <item><description><para><b>listAgentExport</b>: The list of agents</para>
        /// </description></item>
        /// <item><description><para><b>listSkillExport</b>: The list of skills</para>
        /// </description></item>
        /// <item><description><para><b>listModelExport</b>: The list of models</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>database</para>
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        /// <summary>
        /// <para>The language of the content in the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
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
        /// <para>The filter conditions for the exported content.</para>
        /// <remarks>
        /// <para>This is a general-purpose operation for exporting various detection lists from Cloud Security Center. As parameter configurations vary by feature, we recommend that you omit this parameter to export the complete list. You can then filter the data in the exported Excel file.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;extend&quot;:&quot;1&quot;,&quot;currentPage&quot;:1,&quot;pageSize&quot;:10}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The ID of the management account for a member in Resource Directory.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

    }

}
