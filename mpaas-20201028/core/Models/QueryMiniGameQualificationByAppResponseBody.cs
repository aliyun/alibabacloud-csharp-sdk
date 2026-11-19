// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryMiniGameQualificationByAppResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<QueryMiniGameQualificationByAppResponseBodyContent> Content { get; set; }
        public class QueryMiniGameQualificationByAppResponseBodyContent : TeaModel {
            [NameInMap("BusinessLicenseName")]
            [Validation(Required=false)]
            public string BusinessLicenseName { get; set; }

            [NameInMap("BusinessLicenseUrl")]
            [Validation(Required=false)]
            public string BusinessLicenseUrl { get; set; }

            [NameInMap("CopyrightAuthorizationFiles")]
            [Validation(Required=false)]
            public List<QueryMiniGameQualificationByAppResponseBodyContentCopyrightAuthorizationFiles> CopyrightAuthorizationFiles { get; set; }
            public class QueryMiniGameQualificationByAppResponseBodyContentCopyrightAuthorizationFiles : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("CopyrightFileName")]
            [Validation(Required=false)]
            public string CopyrightFileName { get; set; }

            [NameInMap("CopyrightRegistrationNumber")]
            [Validation(Required=false)]
            public string CopyrightRegistrationNumber { get; set; }

            [NameInMap("CopyrightUrl")]
            [Validation(Required=false)]
            public string CopyrightUrl { get; set; }

            [NameInMap("Developer")]
            [Validation(Required=false)]
            public string Developer { get; set; }

            [NameInMap("GameType")]
            [Validation(Required=false)]
            public string GameType { get; set; }

            [NameInMap("GameVersionId")]
            [Validation(Required=false)]
            public string GameVersionId { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("IcpFileName")]
            [Validation(Required=false)]
            public string IcpFileName { get; set; }

            [NameInMap("IcpUrl")]
            [Validation(Required=false)]
            public string IcpUrl { get; set; }

            [NameInMap("IdCode")]
            [Validation(Required=false)]
            public string IdCode { get; set; }

            [NameInMap("IpAuthorizationFiles")]
            [Validation(Required=false)]
            public List<QueryMiniGameQualificationByAppResponseBodyContentIpAuthorizationFiles> IpAuthorizationFiles { get; set; }
            public class QueryMiniGameQualificationByAppResponseBodyContentIpAuthorizationFiles : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("MiniProgramCode")]
            [Validation(Required=false)]
            public string MiniProgramCode { get; set; }

            [NameInMap("MiniProgramId")]
            [Validation(Required=false)]
            public long? MiniProgramId { get; set; }

            [NameInMap("OnlineGamePubReFileName")]
            [Validation(Required=false)]
            public string OnlineGamePubReFileName { get; set; }

            [NameInMap("OnlineGamePubReUrl")]
            [Validation(Required=false)]
            public string OnlineGamePubReUrl { get; set; }

            [NameInMap("PrivacyPolicyUrl")]
            [Validation(Required=false)]
            public string PrivacyPolicyUrl { get; set; }

            [NameInMap("Publisher")]
            [Validation(Required=false)]
            public string Publisher { get; set; }

            [NameInMap("ReviewStatus")]
            [Validation(Required=false)]
            public string ReviewStatus { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMsg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
