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
        /// <para>The type of the check result list that you want to export. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>assetInstance</b>: the list of servers displayed on the Host page</description></item>
        /// <item><description><b>user</b>: the list of fingerprints for accounts</description></item>
        /// <item><description><b>port</b>: the list of fingerprints for ports</description></item>
        /// <item><description><b>process</b>: the list of fingerprints for processes</description></item>
        /// <item><description><b>sca</b>: the list of fingerprints for middleware assets</description></item>
        /// <item><description><b>database</b>: the list of fingerprints for databases</description></item>
        /// <item><description><b>web</b>: the list of fingerprints for web services</description></item>
        /// <item><description><b>software</b>: the list of fingerprints for software assets</description></item>
        /// <item><description><b>cron</b>: the list of fingerprints for scheduled tasks</description></item>
        /// <item><description><b>autorun</b>: the list of fingerprints for startup items</description></item>
        /// <item><description><b>lkm</b>: the list of fingerprints for kernel modules</description></item>
        /// <item><description><b>webserver</b>: the list of fingerprints for websites</description></item>
        /// <item><description><b>virusScanExport</b>: the details of the virus scan tasks</description></item>
        /// <item><description><b>imageVulExport</b>: the list of image system vulnerabilities</description></item>
        /// <item><description><b>imageBaseLineExport</b>: the list of check results for image baselines</description></item>
        /// <item><description><b>imageAffectedMaliciousExport</b>: the list of check results for malicious image samples</description></item>
        /// <item><description><b>baselineCspm</b>: the list of check results for configuration assessment</description></item>
        /// <item><description><b>attack</b>: the list of alert events for attack analysis</description></item>
        /// <item><description><b>accessKey</b>: the list of alerts that are generated for AccessKey pair leaks</description></item>
        /// <item><description><b>exportObjectScanEvents</b>: the list of alerts generated for malicious files</description></item>
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

    }

}
