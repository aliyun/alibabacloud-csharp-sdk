// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class EnableDataReflowRequest : TeaModel {
        [NameInMap("DataReflowOssPath")]
        [Validation(Required=false)]
        public string DataReflowOssPath { get; set; }

        [NameInMap("DataReflowRate")]
        [Validation(Required=false)]
        public long? DataReflowRate { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

    }

}
