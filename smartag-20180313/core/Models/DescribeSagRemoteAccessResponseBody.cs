// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagRemoteAccessResponseBody : TeaModel {
        [NameInMap("RemoteAccesses")]
        [Validation(Required=false)]
        public DescribeSagRemoteAccessResponseBodyRemoteAccesses RemoteAccesses { get; set; }
        public class DescribeSagRemoteAccessResponseBodyRemoteAccesses : TeaModel {
            [NameInMap("RemoteAccess")]
            [Validation(Required=false)]
            public List<DescribeSagRemoteAccessResponseBodyRemoteAccessesRemoteAccess> RemoteAccess { get; set; }
            public class DescribeSagRemoteAccessResponseBodyRemoteAccessesRemoteAccess : TeaModel {
                public string SerialNumber { get; set; }
                public string RemoteAccessIp { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
