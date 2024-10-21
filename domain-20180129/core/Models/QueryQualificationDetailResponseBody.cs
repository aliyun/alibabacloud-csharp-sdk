// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryQualificationDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>92610725MA7G2E****</para>
                /// </summary>
                [NameInMap("CredentialNo")]
                [Validation(Required=false)]
                public string CredentialNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SHSQB</para>
                /// </summary>
                [NameInMap("CredentialType")]
                [Validation(Required=false)]
                public string CredentialType { get; set; }

                [NameInMap("CredentialUrl")]
                [Validation(Required=false)]
                public string CredentialUrl { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9DFCF6F8-243C-****-8035-4B12FEFD7D48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>943a1662898a****0acbdbeca91</para>
        /// </summary>
        [NameInMap("TrackId")]
        [Validation(Required=false)]
        public string TrackId { get; set; }

    }

}
