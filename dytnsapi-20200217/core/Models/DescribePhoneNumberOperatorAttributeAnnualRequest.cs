// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberOperatorAttributeAnnualRequest : TeaModel {
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

    }

}
