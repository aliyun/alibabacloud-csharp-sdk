// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CheckDomainRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("FeeCommand")]
        [Validation(Required=false)]
        public string FeeCommand { get; set; }

        [NameInMap("FeeCurrency")]
        [Validation(Required=false)]
        public string FeeCurrency { get; set; }

        [NameInMap("FeePeriod")]
        [Validation(Required=false)]
        public int? FeePeriod { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
