// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportRecordRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the type of the file to be exported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>virusScanExport</b>: Exports the virus scan task details. This value is required and can only be used when ExportType is set to virusScanExport.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>virusScanExport</para>
        /// </summary>
        [NameInMap("ExportFileType")]
        [Validation(Required=false)]
        public string ExportFileType { get; set; }

        /// <summary>
        /// <para>Specifies the type of the detection result list to be exported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>assetInstance</b>: the server list in the Asset Center</description></item>
        /// <item><description><b>user</b>: the Asset Fingerprints list of accounts</description></item>
        /// <item><description><b>port</b>: the Asset Fingerprints list of ports</description></item>
        /// <item><description><b>process</b>: the Asset Fingerprints list of processes</description></item>
        /// <item><description><b>sca</b>: the Asset Fingerprints list of middleware</description></item>
        /// <item><description><b>database</b>: the Asset Fingerprints list of databases</description></item>
        /// <item><description><b>web</b>: the Asset Fingerprints list of web services</description></item>
        /// <item><description><b>software</b>: the Asset Fingerprints list of software</description></item>
        /// <item><description><b>cron</b>: the Asset Fingerprints list of scheduled nodes</description></item>
        /// <item><description><b>autorun</b>: the Asset Fingerprints list of startup items</description></item>
        /// <item><description><b>lkm</b>: the Asset Fingerprints list of kernel modules</description></item>
        /// <item><description><b>webserver</b>: the Asset Fingerprints list of websites</description></item>
        /// <item><description><b>virusScanExport</b>: the virus scan node details list</description></item>
        /// <item><description><b>imageVulExport</b>: the image system vulnerability list</description></item>
        /// <item><description><b>imageBaseLineExport</b>: the image baseline check result list</description></item>
        /// <item><description><b>imageAffectedMaliciousExport</b>: the image malicious sample check result list</description></item>
        /// <item><description><b>baselineCspm</b>: the cloud platform configuration check result list</description></item>
        /// <item><description><b>attack</b>: the attack analysis alerting event list</description></item>
        /// <item><description><b>accessKey</b>: the AccessKey leak detection alerting event list</description></item>
        /// <item><description><b>exportObjectScanEvents</b>: the malicious file detection alerting event list</description></item>
        /// <item><description><b>domainDetail</b>: the website assets</description></item>
        /// <item><description><b>assetsPropertyScaProcessDetail</b>: the RASP-protected processes in Application Protection</description></item>
        /// <item><description><b>exportHcWarning</b>: the system baseline risk list</description></item>
        /// <item><description><b>raspAttackAlert</b>: the Application Protection attack alerting list</description></item>
        /// <item><description><b>raspApplicationConfiguration</b>: the Application Protection application configuration list</description></item>
        /// <item><description><b>raspWeaknessDetection</b>: the Application Protection weakness detection list</description></item>
        /// <item><description><b>raspInMemoryWebshellDetection</b>: the Application Protection in-memory webshell detection alerting list</description></item>
        /// <item><description><b>raspInMemoryWebshellInsertion</b>: the Application Protection in-memory webshell injection alerting list</description></item>
        /// <item><description><b>listAgentExport</b>: the agent list</description></item>
        /// <item><description><b>listSkillExport</b>: the skill list</description></item>
        /// <item><description><b>listModelExport</b>: the model list</description></item>
        /// <item><description><b>listAiAgentEventExport</b>: the agent risk list</description></item>
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
        /// <para>Specifies the language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies the filter conditions for the exported content.</para>
        /// <remarks>
        /// <para>This operation is a general export operation for exporting detection lists of multiple features in Security Center. The configuration fields of this parameter vary based on the feature. Do not specify this parameter when you call the operation. You can export the information list without specifying this parameter and then filter the target data in the exported Excel file.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;extend&quot;:&quot;1&quot;,&quot;currentPage&quot;:1,&quot;pageSize&quot;:10}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member accounts in the resource folder.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
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
