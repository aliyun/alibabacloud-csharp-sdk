// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoTagScanResultResponseBody : TeaModel {
        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   `true`: The request is successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of vulnerabilities detected on images.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The details about the detected vulnerabilities.
        /// </summary>
        [NameInMap("Vulnerabilities")]
        [Validation(Required=false)]
        public List<ListRepoTagScanResultResponseBodyVulnerabilities> Vulnerabilities { get; set; }
        public class ListRepoTagScanResultResponseBodyVulnerabilities : TeaModel {
            /// <summary>
            /// The ID of the image layer where the vulnerability was detected.
            /// </summary>
            [NameInMap("AddedBy")]
            [Validation(Required=false)]
            public string AddedBy { get; set; }

            /// <summary>
            /// The name of the vulnerability.
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// The URL of the vulnerability.
            /// </summary>
            [NameInMap("CveLink")]
            [Validation(Required=false)]
            public string CveLink { get; set; }

            /// <summary>
            /// The directory of the vulnerability.
            /// </summary>
            [NameInMap("CveLocation")]
            [Validation(Required=false)]
            public string CveLocation { get; set; }

            /// <summary>
            /// The name of the vulnerability.
            /// </summary>
            [NameInMap("CveName")]
            [Validation(Required=false)]
            public string CveName { get; set; }

            /// <summary>
            /// The description of the vulnerability.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The cause of the vulnerability.
            /// </summary>
            [NameInMap("Feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

            /// <summary>
            /// The command used to fix the vulnerability.
            /// </summary>
            [NameInMap("FixCmd")]
            [Validation(Required=false)]
            public string FixCmd { get; set; }

            /// <summary>
            /// The type of the vulnerability. Valid values:
            /// 
            /// *   `cve`: image system vulnerability
            /// *   `sca`: image application vulnerability
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// The severity of the vulnerability.
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// The version of the vulnerability.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// The version where the vulnerability was fixed.
            /// </summary>
            [NameInMap("VersionFixed")]
            [Validation(Required=false)]
            public string VersionFixed { get; set; }

            /// <summary>
            /// The format of the vulnerability.
            /// </summary>
            [NameInMap("VersionFormat")]
            [Validation(Required=false)]
            public string VersionFormat { get; set; }

        }

    }

}
