// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineCallActionRequest : TeaModel {
        [NameInMap("Acc")]
        [Validation(Required=false)]
        public string Acc { get; set; }

        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("Act")]
        [Validation(Required=false)]
        public int? Act { get; set; }

        [NameInMap("Biz")]
        [Validation(Required=false)]
        public string Biz { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("FromSource")]
        [Validation(Required=false)]
        public string FromSource { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
