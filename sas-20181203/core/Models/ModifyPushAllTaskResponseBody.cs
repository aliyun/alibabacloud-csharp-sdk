// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPushAllTaskResponseBody : TeaModel {
        [NameInMap("PushTaskRsp")]
        [Validation(Required=false)]
        public ModifyPushAllTaskResponseBodyPushTaskRsp PushTaskRsp { get; set; }
        public class ModifyPushAllTaskResponseBodyPushTaskRsp : TeaModel {
            [NameInMap("PushTaskResultList")]
            [Validation(Required=false)]
            public List<ModifyPushAllTaskResponseBodyPushTaskRspPushTaskResultList> PushTaskResultList { get; set; }
            public class ModifyPushAllTaskResponseBodyPushTaskRspPushTaskResultList : TeaModel {
                public long? GroupId { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public string Ip { get; set; }
                public string Message { get; set; }
                public bool? Online { get; set; }
                public string OsVersion { get; set; }
                public string Region { get; set; }
                public bool? Success { get; set; }
                public string Uuid { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
