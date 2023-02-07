// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class MakeDoubleCallRequest : TeaModel {
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("BizData")]
        [Validation(Required=false)]
        public string BizData { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MemberPhone")]
        [Validation(Required=false)]
        public string MemberPhone { get; set; }

        [NameInMap("OutboundCallNumber")]
        [Validation(Required=false)]
        public string OutboundCallNumber { get; set; }

        [NameInMap("ServicerPhone")]
        [Validation(Required=false)]
        public string ServicerPhone { get; set; }

    }

}
