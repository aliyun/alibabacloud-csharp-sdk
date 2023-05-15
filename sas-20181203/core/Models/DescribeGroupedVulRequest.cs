// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedVulRequest : TeaModel {
        /// <summary>
        /// $.parameters[10].schema.example
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// Specifies whether the vulnerability is handled. Valid values:
        /// 
        /// **y**: handled **n**: The vulnerability is not handled.
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// The priorities to fix the vulnerabilities. Separate multiple priorities with commas (,). Valid values:
        /// 
        /// *   **asap**: high
        /// *   **later**: medium
        /// *   **nntf**: low
        /// </summary>
        [NameInMap("AttachTypes")]
        [Validation(Required=false)]
        public string AttachTypes { get; set; }

        /// <summary>
        /// The type of the vulnerability. Valid values:
        /// 
        /// *   **cve**: Linux software vulnerability
        /// *   **sys**: Windows system vulnerability
        /// *   **cms**: Web-CMS vulnerability
        /// *   **app**: application vulnerability
        /// *   **emg**: urgent vulnerability
        /// *   **sca**: vulnerability that is detected based on software component analysis
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// $.parameters[11].schema.example
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// $.parameters[11].schema.description
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Code Execution
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// $.parameters[10].schema.enumValueTitles
        /// </summary>
        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        /// <summary>
        /// $.parameters[11].schema.enumValueTitles
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The alias of the vulnerability.
        /// </summary>
        [NameInMap("SearchTags")]
        [Validation(Required=false)]
        public string SearchTags { get; set; }

        /// <summary>
        /// The UUID of the server. Separate multiple UUIDs with commas (,).
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// Queries vulnerabilities by group.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// $.parameters[10].schema.description
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
