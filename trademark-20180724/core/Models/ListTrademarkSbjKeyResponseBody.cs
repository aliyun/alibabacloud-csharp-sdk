// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class ListTrademarkSbjKeyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TmSbjKeyInfo")]
        [Validation(Required=false)]
        public List<ListTrademarkSbjKeyResponseBodyTmSbjKeyInfo> TmSbjKeyInfo { get; set; }
        public class ListTrademarkSbjKeyResponseBodyTmSbjKeyInfo : TeaModel {
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("AgreeProt")]
            [Validation(Required=false)]
            public string AgreeProt { get; set; }

            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public string CertInfo { get; set; }

            [NameInMap("ClearData")]
            [Validation(Required=false)]
            public string ClearData { get; set; }

            [NameInMap("HashData")]
            [Validation(Required=false)]
            public string HashData { get; set; }

            [NameInMap("KeyType")]
            [Validation(Required=false)]
            public int? KeyType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Pin")]
            [Validation(Required=false)]
            public string Pin { get; set; }

            [NameInMap("PrincipalKey")]
            [Validation(Required=false)]
            public string PrincipalKey { get; set; }

            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            [NameInMap("SignCert")]
            [Validation(Required=false)]
            public string SignCert { get; set; }

            [NameInMap("SignData")]
            [Validation(Required=false)]
            public string SignData { get; set; }

            [NameInMap("StartValidDate")]
            [Validation(Required=false)]
            public string StartValidDate { get; set; }

            [NameInMap("SubmitSignData")]
            [Validation(Required=false)]
            public string SubmitSignData { get; set; }

            [NameInMap("TypeCert")]
            [Validation(Required=false)]
            public string TypeCert { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            [NameInMap("ValidDate")]
            [Validation(Required=false)]
            public string ValidDate { get; set; }

            [NameInMap("tmurl")]
            [Validation(Required=false)]
            public string Tmurl { get; set; }

        }

    }

}
