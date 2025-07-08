// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsSignListNewRequest : TeaModel {
        [NameInMap("AggregatedRegisterStatus")]
        [Validation(Required=false)]
        public int? AggregatedRegisterStatus { get; set; }

        [NameInMap("AuditState")]
        [Validation(Required=false)]
        public string AuditState { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("IsGlobeSign")]
        [Validation(Required=false)]
        public int? IsGlobeSign { get; set; }

        [NameInMap("OperatorCodes")]
        [Validation(Required=false)]
        public List<string> OperatorCodes { get; set; }

        [NameInMap("OperatorRegisterStatus")]
        [Validation(Required=false)]
        public int? OperatorRegisterStatus { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("QualificationName")]
        [Validation(Required=false)]
        public string QualificationName { get; set; }

        [NameInMap("RegisterResult")]
        [Validation(Required=false)]
        public int? RegisterResult { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        [NameInMap("SignSource")]
        [Validation(Required=false)]
        public string SignSource { get; set; }

    }

}
