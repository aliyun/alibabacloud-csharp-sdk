// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class AddPhoneNumberRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("Usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

        [NameInMap("ContactFlowId")]
        [Validation(Required=false)]
        public string ContactFlowId { get; set; }

    }

}
