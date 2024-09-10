// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportRecordRequest : TeaModel {
        /// <summary>
        /// The type of the file to export. Valid values:
        /// 
        /// *   **virusScanExport**: The details of the virus scan tasks are exported. This parameter is available and required when ExportType is set to virusScanExport.
        /// </summary>
        [NameInMap("ExportFileType")]
        [Validation(Required=false)]
        public string ExportFileType { get; set; }

        /// <summary>
        /// The type of the check result list that you want to export. Valid values:
        /// 
        /// *   **assetInstance**: the list of servers displayed on the Host page
        /// *   **user**: the list of fingerprints for accounts
        /// *   **port**: the list of fingerprints for ports
        /// *   **process**: the list of fingerprints for processes
        /// *   **sca**: the list of fingerprints for middleware assets
        /// *   **database**: the list of fingerprints for databases
        /// *   **web**: the list of fingerprints for web services
        /// *   **software**: the list of fingerprints for software assets
        /// *   **cron**: the list of fingerprints for scheduled tasks
        /// *   **autorun**: the list of fingerprints for startup items
        /// *   **lkm**: the list of fingerprints for kernel modules
        /// *   **webserver**: the list of fingerprints for websites
        /// *   **virusScanExport**: the details of the virus scan tasks
        /// *   **imageVulExport**: the list of image system vulnerabilities
        /// *   **imageBaseLineExport**: the list of check results for image baselines
        /// *   **imageAffectedMaliciousExport**: the list of check results for malicious image samples
        /// *   **baselineCspm**: the list of check results for configuration assessment
        /// *   **attack**: the list of alert events for attack analysis
        /// *   **accessKey**: the list of alerts that are generated for AccessKey pair leaks
        /// *   **exportObjectScanEvents**: the list of alerts generated for malicious files
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The conditions that are used to filter check results.
        /// 
        /// > This operation is a common export operation for multiple features of Security Center. The available configuration fields of this parameter vary based on the features. We recommend that you do not specify this parameter when you call the operation. You can export an information list without specifying this parameter, and then filter data in the exported Excel file.
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

    }

}
