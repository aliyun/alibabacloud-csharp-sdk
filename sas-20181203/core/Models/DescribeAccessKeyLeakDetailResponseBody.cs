// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAccessKeyLeakDetailResponseBody : TeaModel {
        [NameInMap("AccesskeyId")]
        [Validation(Required=false)]
        public string AccesskeyId { get; set; }

        [NameInMap("Asset")]
        [Validation(Required=false)]
        public string Asset { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DealTime")]
        [Validation(Required=false)]
        public string DealTime { get; set; }

        [NameInMap("DealType")]
        [Validation(Required=false)]
        public string DealType { get; set; }

        [NameInMap("GithubFileName")]
        [Validation(Required=false)]
        public string GithubFileName { get; set; }

        [NameInMap("GithubFileType")]
        [Validation(Required=false)]
        public string GithubFileType { get; set; }

        [NameInMap("GithubFileUpdateTime")]
        [Validation(Required=false)]
        public string GithubFileUpdateTime { get; set; }

        [NameInMap("GithubFileUrl")]
        [Validation(Required=false)]
        public string GithubFileUrl { get; set; }

        [NameInMap("GithubRepoName")]
        [Validation(Required=false)]
        public string GithubRepoName { get; set; }

        [NameInMap("GithubRepoUrl")]
        [Validation(Required=false)]
        public string GithubRepoUrl { get; set; }

        [NameInMap("GithubUser")]
        [Validation(Required=false)]
        public string GithubUser { get; set; }

        [NameInMap("GithubUserPicUrl")]
        [Validation(Required=false)]
        public string GithubUserPicUrl { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("TokenValid")]
        [Validation(Required=false)]
        public int? TokenValid { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("WhitelistStatus")]
        [Validation(Required=false)]
        public string WhitelistStatus { get; set; }

        [NameInMap("WhitelistTime")]
        [Validation(Required=false)]
        public long? WhitelistTime { get; set; }

    }

}
