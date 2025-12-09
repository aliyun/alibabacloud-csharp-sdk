// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportRecordRequest : TeaModel {
        /// <summary>
        /// <para>The type of the file to export. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>virusScanExport</b>: The details of the virus scan tasks are exported. This parameter is available and required when ExportType is set to virusScanExport.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>virusScanExport</para>
        /// </summary>
        [NameInMap("ExportFileType")]
        [Validation(Required=false)]
        public string ExportFileType { get; set; }

        /// <summary>
        /// <para>The type of detection result list to be exported. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>assetInstance</b>: List of servers in the asset center </description></item>
        /// <item><description><b>user</b>: List of asset fingerprints for accounts </description></item>
        /// <item><description><b>port</b>: List of asset fingerprints for ports </description></item>
        /// <item><description><b>process</b>: List of asset fingerprints for processes </description></item>
        /// <item><description><b>sca</b>: List of asset fingerprints for middleware </description></item>
        /// <item><description><b>database</b>: List of asset fingerprints for databases </description></item>
        /// <item><description><b>web</b>: List of asset fingerprints for web services </description></item>
        /// <item><description><b>software</b>: List of asset fingerprints for software </description></item>
        /// <item><description><b>cron</b>: List of asset fingerprints for scheduled tasks </description></item>
        /// <item><description><b>autorun</b>: List of asset fingerprints for startup items </description></item>
        /// <item><description><b>lkm</b>: List of asset fingerprints for kernel modules </description></item>
        /// <item><description><b>webserver</b>: List of asset fingerprints for web sites </description></item>
        /// <item><description><b>virusScanExport</b>: List of details for virus scan tasks </description></item>
        /// <item><description><b>imageVulExport</b>: List of system vulnerabilities in images </description></item>
        /// <item><description><b>imageBaseLineExport</b>: List of baseline check results in images </description></item>
        /// <item><description><b>imageAffectedMaliciousExport</b>: List of malicious sample check results in images </description></item>
        /// <item><description><b>baselineCspm</b>: List of detection results for cloud platform configuration checks </description></item>
        /// <item><description><b>attack</b>: List of alert events for attack analysis </description></item>
        /// <item><description><b>accessKey</b>: List of alert events for AK leak detection </description></item>
        /// <item><description><b>exportObjectScanEvents</b>: List of alert events for malicious file detection </description></item>
        /// <item><description><b>domainDetail</b>: Website assets </description></item>
        /// <item><description><b>assetsPropertyScaProcessDetail</b>: RASP protection process for application protection </description></item>
        /// <item><description><b>exportHcWarning</b>: List of system baseline risks </description></item>
        /// <item><description><b>raspAttackAlert</b>: List of attack alerts for Application Protection</description></item>
        /// <item><description><b>raspApplicationConfiguration</b>: List of application configurations for Application Protection</description></item>
        /// <item><description><b>raspWeaknessDetection</b>: List of weakness detections for Application Protection</description></item>
        /// <item><description><b>raspInMemoryWebshellDetection</b>: List of in-memory webshell detection alerts for Application Protection</description></item>
        /// <item><description><b>raspInMemoryWebshellInsertion</b>: List of in-memory webshell insertion alerts for Application Protection</description></item>
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
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The conditions that are used to filter check results.</para>
        /// <remarks>
        /// <para>This operation is a common export operation for multiple features of Security Center. The available configuration fields of this parameter vary based on the features. We recommend that you do not specify this parameter when you call the operation. You can export an information list without specifying this parameter, and then filter data in the exported Excel file.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;extend&quot;:&quot;1&quot;,&quot;currentPage&quot;:1,&quot;pageSize&quot;:10}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

    }

}
