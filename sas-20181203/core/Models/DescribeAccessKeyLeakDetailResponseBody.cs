// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAccessKeyLeakDetailResponseBody : TeaModel {
        /// <summary>
        /// The ID of the AccessKey pair that is leaked.
        /// </summary>
        [NameInMap("AccesskeyId")]
        [Validation(Required=false)]
        public string AccesskeyId { get; set; }

        /// <summary>
        /// The platform to which the asset belongs. The value is fixed as **Cloud platform**.
        /// </summary>
        [NameInMap("Asset")]
        [Validation(Required=false)]
        public string Asset { get; set; }

        /// <summary>
        /// The code snippet that is leaked.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The time when the AccessKey pair leak was handled.
        /// </summary>
        [NameInMap("DealTime")]
        [Validation(Required=false)]
        public string DealTime { get; set; }

        /// <summary>
        /// The solution to the AccessKey pair leak. Valid values:
        /// 
        /// *   **manual**: manually deleted
        /// *   **disable**: manually disabled
        /// *   **add-whitelist**: added to the whitelist
        /// *   **pending**: unhandled
        /// </summary>
        [NameInMap("DealType")]
        [Validation(Required=false)]
        public string DealType { get; set; }

        /// <summary>
        /// The name of the GitHub file.
        /// </summary>
        [NameInMap("GithubFileName")]
        [Validation(Required=false)]
        public string GithubFileName { get; set; }

        /// <summary>
        /// The type of the GitHub file. Valid values:
        /// 
        /// *   Python
        /// *   XML
        /// *   GO
        /// *   Javascript
        /// *   INI
        /// *   JSON
        /// *   C++
        /// </summary>
        [NameInMap("GithubFileType")]
        [Validation(Required=false)]
        public string GithubFileType { get; set; }

        /// <summary>
        /// The time when the GitHub file was updated.
        /// </summary>
        [NameInMap("GithubFileUpdateTime")]
        [Validation(Required=false)]
        public string GithubFileUpdateTime { get; set; }

        /// <summary>
        /// The URL of the GitHub file.
        /// </summary>
        [NameInMap("GithubFileUrl")]
        [Validation(Required=false)]
        public string GithubFileUrl { get; set; }

        /// <summary>
        /// The name of the GitHub repository.
        /// </summary>
        [NameInMap("GithubRepoName")]
        [Validation(Required=false)]
        public string GithubRepoName { get; set; }

        /// <summary>
        /// The URL of the GitHub repository.
        /// </summary>
        [NameInMap("GithubRepoUrl")]
        [Validation(Required=false)]
        public string GithubRepoUrl { get; set; }

        /// <summary>
        /// The username of the GitHub user.
        /// </summary>
        [NameInMap("GithubUser")]
        [Validation(Required=false)]
        public string GithubUser { get; set; }

        /// <summary>
        /// The URL of the profile picture for the GitHub user.
        /// </summary>
        [NameInMap("GithubUserPicUrl")]
        [Validation(Required=false)]
        public string GithubUserPicUrl { get; set; }

        /// <summary>
        /// The first time when the AccessKey pair leak was detected.
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// The last time when the AccessKey pair leak was detected.
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// The remarks of the AccessKey pair leak.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The platform on which the AccessKey pair leak is detected.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The validity of the key that is associated with the AccessKey pair. Valid values:
        /// 
        /// *   **0**: to be confirmed.
        /// *   **1**: valid.
        /// *   **2**: invalid.
        /// </summary>
        [NameInMap("TokenValid")]
        [Validation(Required=false)]
        public int? TokenValid { get; set; }

        /// <summary>
        /// The type of the leak. The value is fixed as **AccessKey**.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// Indicates whether the AccessKey pair leak is added to the whitelist. Valid values:
        /// 
        /// *   **no**: no
        /// *   **yes**: yes
        /// </summary>
        [NameInMap("WhitelistStatus")]
        [Validation(Required=false)]
        public string WhitelistStatus { get; set; }

        /// <summary>
        /// The time when the AccessKey pair was added to the whitelist. Unit: milliseconds.
        /// </summary>
        [NameInMap("WhitelistTime")]
        [Validation(Required=false)]
        public long? WhitelistTime { get; set; }

    }

}
