// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberAnalysisTransparentRequest : TeaModel {
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        [NameInMap("InputNumber")]
        [Validation(Required=false)]
        public string InputNumber { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("NumberType")]
        [Validation(Required=false)]
        public string NumberType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
