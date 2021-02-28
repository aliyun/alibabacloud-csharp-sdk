// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnUserDomainsRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        [NameInMap("DomainSearchType")]
        [Validation(Required=false)]
        public string DomainSearchType { get; set; }

        [NameInMap("CheckDomainShow")]
        [Validation(Required=false)]
        public bool? CheckDomainShow { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("FuncId")]
        [Validation(Required=false)]
        public string FuncId { get; set; }

        [NameInMap("FuncFilter")]
        [Validation(Required=false)]
        public string FuncFilter { get; set; }

        [NameInMap("ChangeStartTime")]
        [Validation(Required=false)]
        public string ChangeStartTime { get; set; }

        [NameInMap("ChangeEndTime")]
        [Validation(Required=false)]
        public string ChangeEndTime { get; set; }

    }

}
