// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AllLinkeantcodeAntcodeProjectsallResponseBody : TeaModel {
        [NameInMap("ResponsePageInfoNextPage")]
        [Validation(Required=false)]
        public string ResponsePageInfoNextPage { get; set; }

        [NameInMap("ResponsePage")]
        [Validation(Required=false)]
        public string ResponsePage { get; set; }

        [NameInMap("ResponsePageInfoPrevPage")]
        [Validation(Required=false)]
        public string ResponsePageInfoPrevPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResponsePageInfoPerPage")]
        [Validation(Required=false)]
        public string ResponsePageInfoPerPage { get; set; }

        [NameInMap("ResponsePageInfoTotalPages")]
        [Validation(Required=false)]
        public string ResponsePageInfoTotalPages { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("StateCounts")]
        [Validation(Required=false)]
        public List<AllLinkeantcodeAntcodeProjectsallResponseBodyStateCounts> StateCounts { get; set; }
        public class AllLinkeantcodeAntcodeProjectsallResponseBodyStateCounts : TeaModel {
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<AllLinkeantcodeAntcodeProjectsallResponseBodyList> List { get; set; }
        public class AllLinkeantcodeAntcodeProjectsallResponseBodyList : TeaModel {
            [NameInMap("LastActivityAt")]
            [Validation(Required=false)]
            public string LastActivityAt { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("NameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }

            [NameInMap("RepositorySize")]
            [Validation(Required=false)]
            public string RepositorySize { get; set; }

            [NameInMap("PathWithNamespace")]
            [Validation(Required=false)]
            public string PathWithNamespace { get; set; }

            [NameInMap("VisibilityLevel")]
            [Validation(Required=false)]
            public long? VisibilityLevel { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("SshUrlToRepo")]
            [Validation(Required=false)]
            public string SshUrlToRepo { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("HttpUrlToRepo")]
            [Validation(Required=false)]
            public string HttpUrlToRepo { get; set; }

        }

        [NameInMap("ResponsePageInfoTotal")]
        [Validation(Required=false)]
        public string ResponsePageInfoTotal { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
