// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAgentlessMaliciousFilesRequest : TeaModel {
        /// <summary>
        /// The page number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether the vulnerability is handled. Valid values:
        /// 
        /// *   Y: The vulnerability is handled.
        /// *   N: The vulnerability is not handled.
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// The event ID.
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// The name of the malicious file that you want to query.
        /// 
        /// > Fuzzy match is supported.
        /// </summary>
        [NameInMap("FuzzyMaliciousName")]
        [Validation(Required=false)]
        public string FuzzyMaliciousName { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese.
        /// *   **en**: English.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The severities of the malicious files. Separate multiple values with commas (,). Valid values:
        /// 
        /// *   serious
        /// *   suspicious
        /// *   remind
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        /// <summary>
        /// The MD5 hash value of the malicious file.
        /// </summary>
        [NameInMap("MaliciousMd5")]
        [Validation(Required=false)]
        public string MaliciousMd5 { get; set; }

        /// <summary>
        /// The alert type.
        /// 
        /// Valid values when Lang is set to zh:
        /// 
        /// *   WebShell
        /// *   Malicious Software
        /// *   Malicious Script
        /// 
        /// Valid values when Lang is set to en:
        /// 
        /// *   WebShell
        /// *   Malicious Software
        /// *   Malicious Script
        /// </summary>
        [NameInMap("MaliciousType")]
        [Validation(Required=false)]
        public string MaliciousType { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The remarks for the asset affected by the vulnerability. The value can be the private IP address, public IP address, or name of the asset. Fuzzy match is supported.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The source of the malicious file.
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

        /// <summary>
        /// The UUID of the asset.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
