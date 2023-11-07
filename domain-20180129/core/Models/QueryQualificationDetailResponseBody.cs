// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryQualificationDetailResponseBody : TeaModel {
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public int? AuditStatus { get; set; }

        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public QueryQualificationDetailResponseBodyCredentials Credentials { get; set; }
        public class QueryQualificationDetailResponseBodyCredentials : TeaModel {
            [NameInMap("QualificationCredential")]
            [Validation(Required=false)]
            public List<QueryQualificationDetailResponseBodyCredentialsQualificationCredential> QualificationCredential { get; set; }
            public class QueryQualificationDetailResponseBodyCredentialsQualificationCredential : TeaModel {
                [NameInMap("CredentialNo")]
                [Validation(Required=false)]
                public string CredentialNo { get; set; }

                [NameInMap("CredentialType")]
                [Validation(Required=false)]
                public string CredentialType { get; set; }

                [NameInMap("CredentialUrl")]
                [Validation(Required=false)]
                public string CredentialUrl { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrackId")]
        [Validation(Required=false)]
        public string TrackId { get; set; }

    }

}
