// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class GetCMSIdByForeignIdRequest : TeaModel {
        [NameInMap("ForeignId")]
        [Validation(Required=false)]
        public string ForeignId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Nick")]
        [Validation(Required=false)]
        public string Nick { get; set; }

        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public long? SourceId { get; set; }

    }

}
