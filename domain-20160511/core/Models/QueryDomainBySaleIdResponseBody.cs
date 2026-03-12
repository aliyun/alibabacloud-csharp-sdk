// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20160511.Models
{
    public class QueryDomainBySaleIdResponseBody : TeaModel {
        [NameInMap("ChineseContactPerson")]
        [Validation(Required=false)]
        public string ChineseContactPerson { get; set; }

        [NameInMap("ChineseHolder")]
        [Validation(Required=false)]
        public string ChineseHolder { get; set; }

        [NameInMap("CreationDate")]
        [Validation(Required=false)]
        public string CreationDate { get; set; }

        [NameInMap("DnsList")]
        [Validation(Required=false)]
        public QueryDomainBySaleIdResponseBodyDnsList DnsList { get; set; }
        public class QueryDomainBySaleIdResponseBodyDnsList : TeaModel {
            [NameInMap("Dns")]
            [Validation(Required=false)]
            public List<string> Dns { get; set; }

        }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainRegType")]
        [Validation(Required=false)]
        public string DomainRegType { get; set; }

        [NameInMap("EmailVerificationClientHold")]
        [Validation(Required=false)]
        public bool? EmailVerificationClientHold { get; set; }

        [NameInMap("EmailVerificationStatus")]
        [Validation(Required=false)]
        public int? EmailVerificationStatus { get; set; }

        [NameInMap("EnglishContactPerson")]
        [Validation(Required=false)]
        public string EnglishContactPerson { get; set; }

        [NameInMap("EnglishHolder")]
        [Validation(Required=false)]
        public string EnglishHolder { get; set; }

        [NameInMap("ExpirationDate")]
        [Validation(Required=false)]
        public string ExpirationDate { get; set; }

        [NameInMap("HolderEmail")]
        [Validation(Required=false)]
        public string HolderEmail { get; set; }

        [NameInMap("Premium")]
        [Validation(Required=false)]
        public bool? Premium { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("SafetyLock")]
        [Validation(Required=false)]
        public string SafetyLock { get; set; }

        [NameInMap("SaleId")]
        [Validation(Required=false)]
        public string SaleId { get; set; }

        [NameInMap("TransferLock")]
        [Validation(Required=false)]
        public string TransferLock { get; set; }

        [NameInMap("TransferOutStatus")]
        [Validation(Required=false)]
        public string TransferOutStatus { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("WhoisProtected")]
        [Validation(Required=false)]
        public bool? WhoisProtected { get; set; }

    }

}
