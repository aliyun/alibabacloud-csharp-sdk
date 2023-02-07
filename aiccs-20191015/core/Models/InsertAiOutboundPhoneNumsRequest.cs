// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class InsertAiOutboundPhoneNumsRequest : TeaModel {
        [NameInMap("BatchVersion")]
        [Validation(Required=false)]
        public int? BatchVersion { get; set; }

        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<InsertAiOutboundPhoneNumsRequestDetails> Details { get; set; }
        public class InsertAiOutboundPhoneNumsRequestDetails : TeaModel {
            [NameInMap("BizData")]
            [Validation(Required=false)]
            public string BizData { get; set; }

            [NameInMap("PhoneNum")]
            [Validation(Required=false)]
            public string PhoneNum { get; set; }

        }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
