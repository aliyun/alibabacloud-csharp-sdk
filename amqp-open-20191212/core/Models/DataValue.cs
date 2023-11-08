/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class DataValue : TeaModel {
        [NameInMap("masterUid")]
        [Validation(Required=false)]
        public long? MasterUid { get; set; }

        [NameInMap("cInstanceId")]
        [Validation(Required=false)]
        public string CInstanceId { get; set; }

        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("deleted")]
        [Validation(Required=false)]
        public long? Deleted { get; set; }

        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

    }

}
